using System;

namespace UM007.DesignPatternTest.StatePattern
{
    public class HasQuarter : IState
    {
      private readonly GumballMachine _gumballMachine;
        private Random _random = new Random(DateTime.Now.Millisecond);
        public HasQuarter(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("你已经投了一元钱");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("钱已退出");
            this._gumballMachine.SetState(this._gumballMachine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("你可以转动把手");
            this._gumballMachine.SetState(this._random.Next(10) == 0
                ? this._gumballMachine.GetWinnerState()
                : this._gumballMachine.GetSoldState());
        }

        public void Dispense()
        {
            Console.WriteLine("糖果不能出来");
        }
    }
}
