using System;

namespace UM007.DesignPatternTest.StrategyPattern
{
    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("我是一个野鸭");
        }
    }
}
