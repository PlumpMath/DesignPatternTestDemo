using System;

namespace UM007.DesignPatternTest.AbstractFactoryPattern
{
    public class MarinaraSauce : Sauce
    {
        public override void ShowDescription()
        {
            Console.WriteLine("MarinaraSauce");
        }
    }
}
