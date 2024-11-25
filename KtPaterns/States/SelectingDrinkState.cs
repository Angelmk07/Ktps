using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtPaterns.States
{
    public class SelectingDrinkState : ICoffeeMachineState
    {
        public void InsertCoin(CoffeeMachine context)
        {
            Console.WriteLine("Монета уже внесена. Выберите напиток.");
        }

        public void SelectDrink(CoffeeMachine context)
        {
            Console.WriteLine("Напиток выбран. Переход к выдаче напитка.");
            context.SetState(new DispensingDrinkState());
        }

        public void DispenseDrink(CoffeeMachine context)
        {
            Console.WriteLine("Необходимо выбрать напиток перед выдачей.");
        }
    }
}
