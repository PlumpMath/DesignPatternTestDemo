using System;

namespace UM007.DesignPatternTest.FactoryMethodPattern
{
    public class NYCheesePizza : Pizza
    {
        public NYCheesePizza()
        {
            Name = "纽约式奶酪比萨";
            Dough = "薄饼";
            Sauce = "Marinara酱";
            Toppings.Clear();
            Toppings.Add("Regiano高级奶酪");
        }
        public override void Description()
        {
            Console.WriteLine("我是纽约式奶酪比萨");
        }

        public override void Cut()
        {
            Console.WriteLine("我把它切成五角形");
        }
    }
}
