using System;

namespace UM007.DesignPatternTest.DecoratorPattern
{
    public class Sugar : Beverage
    {
        private readonly Beverage _beverage;

        public Sugar(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override double Cost()
        {
            return 0.5 + this._beverage.Cost();
        }

        public override string GetDescription()
        {
            return this._beverage.GetDescription() + ",糖";
        }
    }
}
