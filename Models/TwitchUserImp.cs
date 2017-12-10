using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib;
using TwitchLib.Events.Client;
using TwitchLib.Logging;
using TwitchLib.Models.Client;

namespace Test
{
    public class TwitchUserImp : ITwitchClient
    {
        //Class1 Implementation

        //ITwitchApi Implemenation
        public Badges Badges => throw new NotImplementedException();

        public Bits Bits => throw new NotImplementedException();

        public Blocks Blocks => throw new NotImplementedException();

        public ChannelFeeds ChannelFeeds => throw new NotImplementedException();

        public Channels Channels => throw new NotImplementedException();

        public Chat Chat => throw new NotImplementedException();

        public Clips Clips => throw new NotImplementedException();

        public Collections Collections => throw new NotImplementedException();

        public Communities Communities => throw new NotImplementedException();

        public Debugging Debugging => throw new NotImplementedException();

        public Follows Follows => throw new NotImplementedException();

        public Games Games => throw new NotImplementedException();

        public Ingests Ingests => throw new NotImplementedException();

        public Root Root => throw new NotImplementedException();

        public Search Search => throw new NotImplementedException();

        public IApiSettings Settings => throw new NotImplementedException();

        public Streams Streams => throw new NotImplementedException();

        public Subscriptions Subscriptions => throw new NotImplementedException();

        public Teams Teams => throw new NotImplementedException();

        public ThirdParty ThirdParty => throw new NotImplementedException();

        public Undocumented Undocumented => throw new NotImplementedException();

        public Users Users => throw new NotImplementedException();

        public Videos Videos => throw new NotImplementedException();

        public bool AutoReListenOnException { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MessageEmoteCollection ChannelEmotes => throw new NotImplementedException();

        public ConnectionCredentials ConnectionCredentials { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool DisableAutoPong { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsConnected => throw new NotImplementedException();

        public List<JoinedChannel> JoinedChannels => throw new NotImplementedException();

        public ILogger Logger => throw new NotImplementedException();

        public bool Logging { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool OverrideBeingHostedCheck { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public WhisperMessage PreviousWhisper => throw new NotImplementedException();

        public string TwitchUsername => throw new NotImplementedException();

        public bool WillReplaceEmotes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler<OnBeingHostedArgs> OnBeingHosted;
        public event EventHandler<OnChannelStateChangedArgs> OnChannelStateChanged;
        public event EventHandler<OnChatClearedArgs> OnChatCleared;
        public event EventHandler<OnChatColorChangedArgs> OnChatColorChanged;
        public event EventHandler<OnChatCommandReceivedArgs> OnChatCommandReceived;
        public event EventHandler<OnConnectedArgs> OnConnected;
        public event EventHandler<OnConnectionErrorArgs> OnConnectionError;
        public event EventHandler<OnDisconnectedArgs> OnDisconnected;
        public event EventHandler<OnExistingUsersDetectedArgs> OnExistingUsersDetected;
        public event EventHandler<OnHostingStartedArgs> OnHostingStarted;
        public event EventHandler<OnHostingStoppedArgs> OnHostingStopped;
        public event EventHandler OnHostLeft;
        public event EventHandler<OnIncorrectLoginArgs> OnIncorrectLogin;
        public event EventHandler<OnJoinedChannelArgs> OnJoinedChannel;
        public event EventHandler<OnLeftChannelArgs> OnLeftChannel;
        public event EventHandler<OnLogArgs> OnLog;
        public event EventHandler<OnMessageReceivedArgs> OnMessageReceived;
        public event EventHandler<OnMessageSentArgs> OnMessageSent;
        public event EventHandler<OnModeratorJoinedArgs> OnModeratorJoined;
        public event EventHandler<OnModeratorLeftArgs> OnModeratorLeft;
        public event EventHandler<OnModeratorsReceivedArgs> OnModeratorsReceived;
        public event EventHandler<OnNewSubscriberArgs> OnNewSubscriber;
        public event EventHandler<OnNowHostingArgs> OnNowHosting;
        public event EventHandler<OnReSubscriberArgs> OnReSubscriber;
        public event EventHandler<OnSendReceiveDataArgs> OnSendReceiveData;
        public event EventHandler<OnUserBannedArgs> OnUserBanned;
        public event EventHandler<OnUserJoinedArgs> OnUserJoined;
        public event EventHandler<OnUserLeftArgs> OnUserLeft;
        public event EventHandler<OnUserStateChangedArgs> OnUserStateChanged;
        public event EventHandler<OnUserTimedoutArgs> OnUserTimedout;
        public event EventHandler<OnWhisperCommandReceivedArgs> OnWhisperCommandReceived;
        public event EventHandler<OnWhisperReceivedArgs> OnWhisperReceived;
        public event EventHandler<OnWhisperSentArgs> OnWhisperSent;

        public void AddChatCommandIdentifier(char identifier)
        {
            throw new NotImplementedException();
        }

        public void AddWhisperCommandIdentifier(char identifier)
        {
            throw new NotImplementedException();
        }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public void GetChannelModerators()
        {
            throw new NotImplementedException();
        }

        public void GetChannelModerators(JoinedChannel channel)
        {
            throw new NotImplementedException();
        }

        public void GetChannelModerators(string channel)
        {
            throw new NotImplementedException();
        }

        public JoinedChannel GetJoinedChannel(string channel)
        {
            throw new NotImplementedException();
        }

        public void JoinChannel(string channel, bool overrideCheck = false)
        {
            throw new NotImplementedException();
        }

        public void LeaveChannel(JoinedChannel channel)
        {
            throw new NotImplementedException();
        }

        public void LeaveChannel(string channel)
        {
            throw new NotImplementedException();
        }

        public void OnReadLineTest(string rawIrc)
        {
            throw new NotImplementedException();
        }

        public void Reconnect()
        {
            throw new NotImplementedException();
        }

        public void RemoveChatCommandIdentifier(char identifier)
        {
            throw new NotImplementedException();
        }

        public void RemoveWhisperCommandIdentifier(char identifier)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(JoinedChannel channel, string message, bool dryRun = false)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string message, bool dryRun = false)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string channel, string message, bool dryRun = false)
        {
            throw new NotImplementedException();
        }

        public void SendRaw(string message)
        {
            throw new NotImplementedException();
        }

        public void SendWhisper(string receiver, string message, bool dryRun = false)
        {
            throw new NotImplementedException();
        }
    }
}
