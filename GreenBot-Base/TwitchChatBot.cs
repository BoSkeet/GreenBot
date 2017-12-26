using System;
using TwitchLib;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;
using TwitchLib.Models.API.v5;
using System.Resources;
using GreenBot_Base;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;

namespace BetterChatBot
{
    internal class TwitchChatBot
    {
        
        private readonly ConnectionCredentials credentials = new ConnectionCredentials(TwitchInfo.BotUsername, TwitchInfo.BotToken);
        private ITwitchClient client;
        private static string channel;
        private static string name;
        private static string key;

        internal void Connect()
        {
            /*ConsoleWriterMain.Program consoleWriter = new ConsoleWriterMain.Program();
            Process.Start(consoleWriter.ReturnPath() + "\\ConsoleWriterMain.exe");
            Console.ReadLine();*/

            client = new TwitchClient(credentials, TwitchInfo.ChannelName, logging: false);

            client.OnJoinedChannel += Client_OnJoinedChannel;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnMessageSent += Client_OnMessageSent;
            client.OnWhisperSent += Client_OnWhisperSent;

            client.Connect();
        }

        public TwitchChatBot(string _name, string _key, string _channel)
        {
            name = _name;
            key = _key;
            channel = _channel;
        }

        //start -- client events
        private void Client_OnWhisperSent(object sender, OnWhisperSentArgs e)
        {
            throw new NotImplementedException();
        }

        private void Client_OnMessageSent(object sender, OnMessageSentArgs e)
        {
            throw new NotImplementedException();
        }

        private void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            client.SendMessage($"LUL {e.Channel}");
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            client.SendMessage($"EleGiggle {e.AutoJoinChannel}");
            
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Message.StartsWith("LUL", StringComparison.InvariantCultureIgnoreCase))
            {
                client.SendMessage($"FailFish {e.ChatMessage.DisplayName}");
                Console.WriteLine("received message from {0}, chatting: {1}: ", e.ChatMessage.DisplayName, $"hello {e.ChatMessage.DisplayName}");
            }
        }
        //end -- client events

        internal void Disconnect()
        {
            Console.WriteLine("Disconnecting");
        }

        private void Client_OnLog(object sender, OnLogArgs e)
        {
            //Console.WriteLine(e.Data);
        }

        private void Client_OnConnectionError(object sender, OnConnectionErrorArgs e)
        {
            Console.WriteLine($"Error!! {e.Error}");
        }

    }
}