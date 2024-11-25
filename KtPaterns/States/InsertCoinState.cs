using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtPaterns.States
{
    public class InsertCoinState : ICoffeeMachineState
    {
        public void InsertCoin(CoffeeMachine context)
        {
            Console.WriteLine("Монета внесена. Переход к выбору напитка");
            context.SetState(new SelectingDrinkState());
        }

        public void SelectDrink(CoffeeMachine context)
        {
            Console.WriteLine("Необходимо внести монету");
        }

        public void DispenseDrink(CoffeeMachine context)
        {
            Console.WriteLine("Необходимо выбрать напиток");
        }
    }
}
