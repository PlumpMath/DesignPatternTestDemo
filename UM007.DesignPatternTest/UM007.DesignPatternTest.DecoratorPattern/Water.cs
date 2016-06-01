using System;

namespace UM007.DesignPatternTest.DecoratorPattern
{
    public class Water : Beverage
    {
        public Water ()
        {
            base.Description = "水";
        }

        public override double Cost()
        {
            return 1.00;
        }
    }
}
