using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtPaterns.Builder
{

    class Drink : OrderDecorator
    {
        public Drink(IOrder order) : base(order) { }

        public override string GetDescription()
        {
            return order.GetDescription() + ", добавлен напиток напиток";
        }

        public override int GetPrice()
        {
            return order.GetPrice() + 40;
        }
    }
}
