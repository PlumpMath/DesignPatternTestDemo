using System;

namespace UM007.DesignPatternTest.AbstractFactoryPattern
{
    public class ThinCrustDough : Dough
    {
        public override void ShowDescription()
        {
            Console.WriteLine("薄饼面。。");
        }
    }
}
