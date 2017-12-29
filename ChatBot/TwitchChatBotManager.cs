using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib;

namespace GreenBot_Base
{
    public class TwitchChatBotManager
    {
        public Stack<TwitchChatBot.TwitchChatBot> twitchChatBotManager = new Stack<TwitchChatBot.TwitchChatBot>();
    }
}
