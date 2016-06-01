using System;

namespace UM007.DesignPatternTest.StrategyPattern
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("我是一个橡皮鸭");
        }
    }
}
