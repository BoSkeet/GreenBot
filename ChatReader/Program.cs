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

        static void Main(string[] args)
        {
            BetterChatBot.TwitchChatBot twitchChatBot = new BetterChatBot.TwitchChatBot();

            do
            {
                userCommand = Console.ReadLine();
                if (userCommand!=null)
                {
                    twitchChatBot.SendMessage(TwitchInfo.ChannelName, userCommand);
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
