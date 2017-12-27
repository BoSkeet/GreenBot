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
        static void Main(string[] args)
        {
            BetterChatBot.TwitchChatBot twitchChatBot = new BetterChatBot.TwitchChatBot();

            Console.ReadLine();
        }

        public string ReturnPath()
        {
            string folder = Environment.CurrentDirectory;
            return folder;
        }

        public Program() { }
    }
}
