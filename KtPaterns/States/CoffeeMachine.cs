using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtPaterns.States
{
    public class CoffeeMachine
    {
        private ICoffeeMachineState _currentState;

        public CoffeeMachine()
        {
            _currentState = new InsertCoinState();
        }

        public void SetState(ICoffeeMachineState state)
        {
            _currentState = state;
        }

        public void InsertCoin()
        {
            _currentState.InsertCoin(this);
        }

        public void SelectDrink()
        {
            _currentState.SelectDrink(this);
        }

        public void DispenseDrink()
        {
            _currentState.DispenseDrink(this);
        }
    }
}
