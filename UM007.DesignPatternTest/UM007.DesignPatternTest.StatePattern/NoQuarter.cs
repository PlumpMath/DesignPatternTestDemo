using System;

namespace UM007.DesignPatternTest.StatePattern
{
    public class NoQuarter : IState
    {
        private readonly GumballMachine _gumballMachine;
        public NoQuarter(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("你投入了一元钱");
            this._gumballMachine.SetState(this._gumballMachine.GetHasQuarter());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("你没投钱，不能退钱");
        }

        public void TurnCrank()
        {
            Console.WriteLine("你没投钱，不能转动把手");
        }

        public void Dispense()
        {
            Console.WriteLine("不会出为糖的");
        }
    }
}
