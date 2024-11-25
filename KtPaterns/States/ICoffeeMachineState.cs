using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtPaterns.States
{
    public interface ICoffeeMachineState
    {
        void InsertCoin(CoffeeMachine context);
        void SelectDrink(CoffeeMachine context);
        void DispenseDrink(CoffeeMachine context);
    }
}
