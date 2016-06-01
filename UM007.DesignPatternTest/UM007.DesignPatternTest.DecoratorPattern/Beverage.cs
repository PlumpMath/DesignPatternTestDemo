namespace UM007.DesignPatternTest.DecoratorPattern
{
    public abstract class Beverage
    {
        protected string Description = "Unknown beverage";

        public abstract double Cost();

        public virtual string GetDescription()
        {
            return Description;
        }
    }
}
