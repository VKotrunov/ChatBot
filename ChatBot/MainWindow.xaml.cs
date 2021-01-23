using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatBot
{
    public partial class MainWindow : Window
    {
        ObservableCollection<Message> messages;

        public MainWindow()
        {
            messages = new ObservableCollection<Message>();
            InitializeComponent();
            messagesItemsControl.DataContext = messages;
        }

        private void NewChatCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (messages.Count != 0)
                e.CanExecute = true;
        }

        private void NewChatCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            messages = new ObservableCollection<Message>();
        }

        private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (messages.Count != 0)
                e.CanExecute = true;
        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos de texto (*.txt)|*.txt";
            sfd.ShowDialog();
            string fileName = sfd.FileName;
            if (string.IsNullOrEmpty(fileName))
                MessageBox.Show("No se guardó la información", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                StringBuilder data = new StringBuilder();
                foreach (Message item in messages)
                {
                    data.Append(item.Sender + ":" + item.MessageText + "\n");
                }
                File.WriteAllText(fileName, data.ToString());
                MessageBox.Show("Guardado correctamente", "Guardado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void SettingsCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }

        private void SettingsCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CheckConnectionCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Conexión correcta con el servidor del Bot", "Comprobar conexión", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void CheckConnectionCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SendCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (newMessageTextBox.Text != "")
                e.CanExecute = true;
        }

        private void SendCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            messages.Add(new Message(newMessageTextBox.Text, "User"));
            messages.Add(new Message("Lo siento, estoy un poco cansado para hablar.", "Bot"));
            newMessageTextBox.Text = "";
        }
    }
}
