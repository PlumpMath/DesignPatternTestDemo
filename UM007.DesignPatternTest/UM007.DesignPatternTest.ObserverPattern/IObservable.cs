namespace UM007.DesignPatternTest.ObserverPattern
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);

        void DeleteObserver(IObserver observer);

        void NotifyObserver();
    }
}
