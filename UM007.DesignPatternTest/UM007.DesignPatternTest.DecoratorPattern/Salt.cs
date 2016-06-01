namespace UM007.DesignPatternTest.DecoratorPattern
{
    public class Salt : Beverage
    {
        private readonly Beverage _beverage;

        public Salt(Beverage beverage)
        {
            this._beverage = beverage;
        }
        public override double Cost()
        {
            return 0.2 + this._beverage.Cost();
        }

        public override string GetDescription()
        {
            return this._beverage.GetDescription() + ",盐";
        }
    }
}
