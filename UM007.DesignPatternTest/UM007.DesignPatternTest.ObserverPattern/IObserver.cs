namespace UM007.DesignPatternTest.ObserverPattern
{
    public interface IObserver
    {
        void Update(double currentValue);

        void JoinObserve();

        void QuitObserve();
    }
}
