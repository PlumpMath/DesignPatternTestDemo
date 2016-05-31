namespace UM007.DesignPatternTest.StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            duck.SetFlyBehavior(new FlyWithWings());
            duck.Display();
            duck.Fly();
            duck = new RubberDuck();
            duck.SetFlyBehavior(new FlyNoWay());
            duck.Display();
            duck.Fly();
        }
    }
}
