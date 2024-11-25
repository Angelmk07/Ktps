using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtPaterns.Builder
{
    internal interface IOrder
    {
       int GetPrice();
       string GetDescription();
    }
}
