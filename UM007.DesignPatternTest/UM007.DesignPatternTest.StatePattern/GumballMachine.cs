using System;

namespace UM007.DesignPatternTest.StatePattern
{
    public class GumballMachine
    {
        private readonly IState _noQuarter;
        private readonly IState _hasQuarter;
        private readonly IState _soldState;
        private readonly IState _soldOutState;
        private readonly IState _winnerState;
        private IState _state;
        private int _count;

        public GumballMachine()
        {
            this._noQuarter = new NoQuarter(this);
            this._hasQuarter = new HasQuarter(this);
            this._soldState = new Sold(this);
            this._soldOutState = new SoldOut(this);
            this._winnerState = new WinnerState(this);
            this._state = this._soldOutState;
            this._count = 0;
        }

        public void InsertQuarter()
        {
            this._state.InsertQuarter();
        }

        public void EjectQuqrter()
        {
            this._state.EjectQuarter();
        }

        public void TurnCrank()
        {
            this._state.TurnCrank();
            this._state.Dispense();
        }

        public void SetState(IState state)
        {
            this._state = state;
        }

        public void SetCount(int count)
        {
            this._count = count;
            this._state = this._noQuarter;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("已经卖出一个糖果");
            if (this._count != 0)
            {
                this._count--;
            }
        }

        public IState GetNoQuarterState()
        {
            return this._noQuarter;
        }

        public IState GetHasQuarter()
        {
            return this._hasQuarter;
        }

        public IState GetSoldState()
        {
            return this._soldState;
        }

        public IState GetSoldOutState()
        {
            return this._soldOutState;
        }

        public IState GetWinnerState()
        {
            return this._winnerState;
        }

        public int GetCount()
        {
            return this._count;
        }
    }
}
