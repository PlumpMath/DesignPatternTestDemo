using System;

namespace UM007.DesignPatternTest.StrategyPattern
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("我可以用翅膀飞");
        }
    }
}
