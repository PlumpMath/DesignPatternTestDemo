using System;

namespace UM007.DesignPatternTest.SimpleFactoryPattern
{
    public class GreekPizza : Pizza
    {
        public override void Description()
        {
            Console.WriteLine("我是纽约式希腊比萨");
        }
    }
}
