using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatBot
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand NewChat = new RoutedUICommand
            (
                "NewChat",
                "NewChat",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.N, ModifierKeys.Control)
                }
            );
        public static readonly RoutedUICommand Save = new RoutedUICommand
            (
                "Save",
                "Save",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.G, ModifierKeys.Control)
                }
            );
        public static readonly RoutedUICommand Settings = new RoutedUICommand
            (
                "Settings",
                "Settings",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.C, ModifierKeys.Control)
                }
            );
        public static readonly RoutedUICommand CheckConnection = new RoutedUICommand
        (
            "CheckConnection",
            "CheckConnection",
            typeof(CustomCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.O, ModifierKeys.Control)
            }
        );
        public static readonly RoutedUICommand Exit = new RoutedUICommand
        (
            "Exit",
            "Exit",
            typeof(CustomCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.S, ModifierKeys.Control)
            }
        );
        public static readonly RoutedUICommand Send = new RoutedUICommand
        (
            "Send",
            "Send",
            typeof(CustomCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.E, ModifierKeys.Control)
            }
        );
    }
}
