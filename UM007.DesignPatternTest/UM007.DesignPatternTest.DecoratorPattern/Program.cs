using System;

namespace UM007.DesignPatternTest.DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage water = new Water();
            Console.WriteLine(water.GetDescription() + ",价钱{0}", water.Cost());
            water = new Sugar(water);
            Console.WriteLine(water.GetDescription() + ",价钱{0}", water.Cost());
            water = new Salt(water);
            Console.WriteLine(water.GetDescription() + ",价钱{0}", water.Cost());
        }
    }
}
