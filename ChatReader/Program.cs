using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenBot_Base;

namespace ConsoleWriterMain
{
    public class Program
    {
        /// <summary>
        /// when user types in Console send it to the chat
        /// </summary>
        static string userCommand;

        /// <summary>
        /// read only array of strings for Bot keywords
        /// </summary>
        static string[] reservedWords = new string[] { "w", "stop", "close", "enter"};

        static void Main(string[] args)
        {
            BetterChatBot.TwitchChatBot twitchChatBot = new BetterChatBot.TwitchChatBot();

            do
            {
                string[] messageArgs;
                userCommand = Console.ReadLine();

                // determine if the command is a message, whisper or a command
                if (!reservedWords.Contains(userCommand))
                {
                    twitchChatBot.SendMessage(TwitchInfo.ChannelName, userCommand);
                }
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
            } while (true);

        }

        public string ReturnPath()
        {
            string folder = Environment.CurrentDirectory;
            return folder;
        }

        public Program() { }
    }
}
