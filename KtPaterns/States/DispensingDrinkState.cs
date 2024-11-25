using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtPaterns.States
{
    internal class DispensingDrinkState : ICoffeeMachineState
    {
        public void DispenseDrink(CoffeeMachine context)
        {
            Console.WriteLine("Напиток выдан");
            context.SetState( new InsertCoinState());
        }

        public void InsertCoin(CoffeeMachine context) 
        {
            Console.WriteLine("Монета уже вненсена");
        }

        public void SelectDrink(CoffeeMachine context)
        {
            Console.WriteLine("Напиток выдается");
        }
    }
}
