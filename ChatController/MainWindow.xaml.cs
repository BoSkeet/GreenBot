using System;
using System.Collections.Generic;
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
using GreenBot_Base;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// when user types in Console send it to the chat
        /// </summary>
        static string userCommand;

        /// <summary>
        /// read only array of strings for Bot keywords
        /// </summary>
        private static readonly string[] reservedWords = new string[] { "w", "stop", "close", "enter" };

        /// <summary>
        /// Currently only supports one bot 
        /// TODO: multiple bot support?
        /// </summary>
        TwitchChatBot.TwitchChatBot twitchChatBot = new TwitchChatBot.TwitchChatBot();

        public bool isOnline = false;

        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            userNameTB.Text = 
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void messageCommand(string commandArgs)
        {
            TwitchChatBot.TwitchChatBot twitchChatBot = new TwitchChatBot.TwitchChatBot();
            string[] messageArgs;
            userCommand = Console.ReadLine();

            // determine if the command is a message, whisper or a command
            if (!reservedWords.Contains(userCommand))
            {
                twitchChatBot.SendMessage(TwitchInfo.ChannelName, userCommand);
            }
            // command - whisper
            else if (userCommand == "w")
            {
                EnterCommand:

                Console.WriteLine("BOT -- Recipient,Message");
                string userparam = Console.ReadLine();
                messageArgs = userparam.Split(',');

                try
                {
                    twitchChatBot.SendWhisper(messageArgs[0], messageArgs[1]);
                }
                catch
                {
                    Console.WriteLine("BOT -- please enter something valid");
                    goto EnterCommand;
                }
            }
            // rest of commands TODO:
        }

        private void sendToChatWindow(string )
        {
            Chat
        }
    }
}
