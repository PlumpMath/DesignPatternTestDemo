namespace UM007.DesignPatternTest.ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData observable = new WeatherData();
            IObserver observer = new GeneralDisplay(observable);
            IObserver observerOther = new StatisticsDisplay(observable);
            observable.SetCurrentTemperature(12.2);
            observerOther.QuitObserve();
            observable.SetCurrentTemperature(15.2);
        }
    }
}
