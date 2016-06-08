using System;

namespace UM007.DesignPatternTest.StatePattern
{
    public class Sold : IState
    {
        private readonly GumballMachine _gumballMachine;
        public Sold(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("正在贩卖中，不能投钱");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("已经转动把手，不能退钱");
        }

        public void TurnCrank()
        {
            Console.WriteLine("你转了也没用，只能给你一个糖");
        }

        public void Dispense()
        {
            this._gumballMachine.ReleaseBall();
            this._gumballMachine.SetState(this._gumballMachine.GetCount() > 0
                ? this._gumballMachine.GetNoQuarterState()
                : this._gumballMachine.GetSoldOutState());
            Console.WriteLine("o.o, 出来了一个糖");
        }
    }
}
