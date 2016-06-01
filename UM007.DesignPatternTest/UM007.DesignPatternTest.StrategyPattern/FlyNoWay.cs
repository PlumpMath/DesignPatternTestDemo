using System;

namespace UM007.DesignPatternTest.StrategyPattern
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("我不会飞");
        }
    }
}
