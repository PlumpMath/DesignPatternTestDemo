using System;

namespace UM007.DesignPatternTest.FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyps = new NYPizzaStore();
            Pizza pizza = nyps.OrderPizza();
            Console.WriteLine("你点了一份：{0}", pizza.GetName());
        }
    }
}
