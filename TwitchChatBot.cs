using System;
using TwitchLib;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;
using TwitchLib.Models.API.v5;

namespace BetterChatBot
{
    internal class TwitchChatBot
    {
        readonly ConnectionCredentials credentials = new ConnectionCredentials(TwitchInfo.BotUsername, TwitchInfo.BotToken);
        ITwitchClient client;
        ITwitchClient client2;
        private string channel1;
        private string channel2;
        private string name;
        private string key;

        internal void Connect()
        {
            Console.WriteLine("Connecting");

            client = new TwitchClient(credentials, TwitchInfo.ChannelName1, logging: false);

            
            client.OnJoinedChannel += Client1_OnJoinedChannel;
            client.OnMessageReceived += Client1_OnMessageReceived;

            client.Connect();
        }

        //
        //start -- client 1 
        //
        private void Client1_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            client.SendMessage($"LUL {e.Channel}");
        }

        private void Client1_OnConnected(object sender, OnConnectedArgs e)
        {
            client.SendMessage($"EleGiggle {e.AutoJoinChannel}");
        }

        private void Client1_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Message.StartsWith("LUL", StringComparison.InvariantCultureIgnoreCase))
            {
                client.SendMessage($"FailFish {e.ChatMessage.DisplayName}");
            }
        }
        //
        //end -- client 1
        //

        //
        //start -- client 2
        //
        //private void Client2_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        //{
        //    client2.SendMessage($"LUL {e.Channel}");
        //}

        //private void Client2_OnConnected(object sender, OnConnectedArgs e)
        //{
        //    client2.SendMessage($"EleGiggle {e.AutoJoinChannel}");
        //}

        //private void Client2_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        //{
        //    if (e.ChatMessage.Message.StartsWith("LUL", StringComparison.InvariantCultureIgnoreCase))
        //    {
        //        client2.SendMessage($"cmonBruh {e.ChatMessage.DisplayName}");
        //    }
        //}
        //
        //end -- client 2
        //

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

        public TwitchChatBot(string name, string key, string channel1, string channel2)
        {
            this.name = name;
            this.key = name;
            this.channel1 = channel1;
            this.channel2 = channel2;
        }
    }
}