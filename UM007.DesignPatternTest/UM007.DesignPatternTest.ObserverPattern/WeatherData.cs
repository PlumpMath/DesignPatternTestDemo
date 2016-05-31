using System.Collections.Generic;

namespace UM007.DesignPatternTest.ObserverPattern
{
    public class WeatherData : IObservable
    {
        private readonly IList<IObserver> _observers;
        private double _current;

        public WeatherData()
        {
            this._observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void DeleteObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_current);
            }
        }

        public void  SetCurrentTemperature(double current)
        {
            this._current = current;
            MeasurementsChanged();
        }

        private void MeasurementsChanged()
        {
            NotifyObserver();
        }
    }
}
