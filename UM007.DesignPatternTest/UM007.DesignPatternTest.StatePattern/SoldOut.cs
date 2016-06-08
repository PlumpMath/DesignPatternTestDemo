using System;

namespace UM007.DesignPatternTest.StatePattern
{
    public class SoldOut : IState
    {
               private readonly GumballMachine _gumballMachine;
        public SoldOut(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("已卖光，不能投钱");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("没有投钱，不能退钱");
        }

        public void TurnCrank()
        {
            Console.WriteLine("你转了也没用，不能给你糖");
        }

        public void Dispense()
        {
            Console.WriteLine("o.o, 不会出来一个糖");
        }
    }
}
