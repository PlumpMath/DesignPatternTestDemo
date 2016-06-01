namespace UM007.DesignPatternTest.StrategyPattern
{
    public abstract class Duck
    {
        private IFlyBehavior _fly;

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _fly = flyBehavior;
        }

        public void Fly()
        {
            _fly.Fly();
        }

        public abstract void Display();
    }
}
