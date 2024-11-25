using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtPaterns.Chat
{
    internal class ChatMediator : IChatMediator
    {
        List<ChatMember> members = new List<ChatMember>();
        public void registrate(ChatMember chatMember)
        {
            members.Add(chatMember);
        }

        public void sendMessage(String info,ChatMember CendMember)
        {
            foreach (ChatMember chatMember in members)
            {
                if (chatMember == CendMember)
                {
                    continue;
                }
                chatMember.resive(info);
            }
        }
    }
}
