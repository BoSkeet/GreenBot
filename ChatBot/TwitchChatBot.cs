using System;
using TwitchLib;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;
using TwitchLib.Models.API.v5;
using System.Resources;
using GreenBot_Base;
using System.Linq;

namespace BetterChatBot
{
    public class TwitchChatBot
    {
        
        private readonly ConnectionCredentials credentials = new ConnectionCredentials(Name, Key);
        private ITwitchClient client;
        public static string Channel { get; private set; } = TwitchInfo.ChannelName;
        public static string Name { get; private set; } = TwitchInfo.BotUsername;
        private static string Key { get; set; } = TwitchInfo.BotToken;
        private static readonly string ReceiveString = "this is a random message";
        private static readonly string SenderString = "this is a random response";

        public TwitchChatBot()
        {
            Connect();
        }

        public void Connect()
        {
            /*ConsoleWriterMain.Program consoleWriter = new ConsoleWriterMain.Program();
            Process.Start(consoleWriter.ReturnPath() + "\\ConsoleWriterMain.exe");
            Console.ReadLine();*/

            client = new TwitchClient(credentials, Channel, logging: false);

            client.OnJoinedChannel += Client_OnJoinedChannel;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnMessageSent += Client_OnMessageSent;
            client.OnWhisperSent += Client_OnWhisperSent;

            client.Connect();
        }
        
        //start -- client events
        private void Client_OnWhisperSent(object sender, OnWhisperSentArgs e)
        {
            throw new NotImplementedException();
        }

        private void Client_OnMessageSent(object sender, OnMessageSentArgs e)
        {
            //Console.WriteLine("received message from {0}, chatting: {1}: ", e.ChatMessage.DisplayName, $" {SenderString}, {e.ChatMessage.DisplayName}");
        }

        private void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            client.SendMessage($"LUL {e.Channel}");
            Console.WriteLine("Joined Channel: {0}", e.Channel);
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            client.SendMessage($"EleGiggle {e.AutoJoinChannel}");
            Console.WriteLine($"joined {e.AutoJoinChannel}");
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Message.StartsWith(ReceiveString, StringComparison.InvariantCultureIgnoreCase))
            {
                client.SendMessage($"{SenderString}, {e.ChatMessage.DisplayName}");
                Console.WriteLine("message from: {0}\n-- chatting: {1}: ", e.ChatMessage.DisplayName, $" {SenderString}, {e.ChatMessage.DisplayName}");
            }
            else if (e.ChatMessage.Message.Equals("hello greenbot"))
            {
                client.SendMessage($"hello {e.ChatMessage.DisplayName}");
                Console.WriteLine("message from: {0}\n-- chatting: {1}: ", e.ChatMessage.DisplayName, $"hello, {e.ChatMessage.DisplayName}");
            }
            else
            {
                Console.WriteLine("message from -- {0}: {1}", e.ChatMessage.DisplayName, e.ChatMessage.Message);
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