using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    public class Message : INotifyPropertyChanged
    {

        private string _messageText;

        public string MessageText
        {
            get { return _messageText; }
            set
            {
                _messageText = value;
                NotifyPropertyChanged("MessageText");
            }
        }

        private string _sender;

        public string Sender
        {
            get { return _sender; }
            set
            {
                _sender = value;
                NotifyPropertyChanged("Sender");
            }
        }

        public Message(string message, string sender)
        {
            this.MessageText = message;
            this.Sender = sender;
        }

        public Message()
        {
            MessageText = "";
            Sender = "";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
