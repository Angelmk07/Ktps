using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtPaterns.Chat
{
    internal class ChatMember : IChatMember
    {
        private readonly IChatMediator _mediator;

        public string Name { get; }

        public ChatMember(string name, IChatMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public void resive(string info)
        {
            Console.WriteLine($"получено сообщение {info}");
        }

        public void send(string message)
        {
            {
                Console.WriteLine($"{Name} отправляет сообщение: {message}");
                _mediator.sendMessage(message, this);
            }
        }
    }
}
