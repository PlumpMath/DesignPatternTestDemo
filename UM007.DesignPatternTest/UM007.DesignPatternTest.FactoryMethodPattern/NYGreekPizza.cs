using System;

namespace UM007.DesignPatternTest.FactoryMethodPattern
{
    public class NYGreekPizza : Pizza
    {
        public NYGreekPizza()
        {
            Name = "纽约式希腊比萨";
            Dough = "薄饼";
            Sauce = "Marinara酱";
            Toppings.Clear();
            Toppings.Add("Regiano高级奶酪");
        }
        public override void Description()
        {
            Console.WriteLine("我是纽约式希腊比萨");
        }
    }
}
