using System;

namespace UM007.DesignPatternTest.ObserverPattern
{
    public class GeneralDisplay : IObserver, IDisplay
    {
        private double _current;
        private readonly IObservable _observable;

        public GeneralDisplay(IObservable observable)
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
            this._current = currentValue;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("当前温度为{0}",this._current);
        }
    }
}
