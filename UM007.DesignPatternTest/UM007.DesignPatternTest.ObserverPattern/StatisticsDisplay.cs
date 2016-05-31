using System;

namespace UM007.DesignPatternTest.ObserverPattern
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private double _currentValue;
        private readonly IObservable _observable;

        public StatisticsDisplay(IObservable observable)
        {
            this._observable = observable;
            JoinObserve();
        }

        public void QuitObserve()
        {
            this._observable.DeleteObserver(this);
        }

        public void JoinObserve()
        {
            this._observable.AddObserver(this);
        }
        public void Update(double currentValue)
        {
            this._currentValue = currentValue;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("我是统计显示，当前温度为{0}",this._currentValue);
        }
    }
}
