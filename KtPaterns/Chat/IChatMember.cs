﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtPaterns.Chat
{
    internal interface IChatMember
    {
        void send(string info);
        void resive(String info);
    }
}
