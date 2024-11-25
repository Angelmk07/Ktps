using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtPaterns.Builder
{
    internal class BaseOrder : IOrder
    {
        private const int price = 100;
        private string info;

        public BaseOrder()
        {
            info = "Базовый заказ";
        }

        public string GetDescription()
        {
            return info;
        }

        public int GetPrice()
        {
            return price;
        }
    }
}
