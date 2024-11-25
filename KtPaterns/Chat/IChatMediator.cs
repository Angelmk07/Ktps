using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtPaterns.Chat
{
    internal interface IChatMediator
    {
        void registrate(ChatMember chatMember);
        void sendMessage(String info, ChatMember CendMember);
    }
}
