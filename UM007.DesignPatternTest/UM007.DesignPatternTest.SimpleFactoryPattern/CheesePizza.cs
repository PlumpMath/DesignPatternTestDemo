using System;

namespace UM007.DesignPatternTest.SimpleFactoryPattern
{
    public class NYCheesePizza : Pizza
    {
        public override void Description()
        {
            Console.WriteLine("我是纽约式奶酪比萨");
        }
    }
}
