namespace UM007.DesignPatternTest.SimpleFactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza GetPizza(string pizzaType)
        {
            switch (pizzaType)
            {
                case "cheese":
                    return new CheesePizza();
                case"greek":
                    return new GreekPizza();
                default:
                    return new Pizza();
            }
        }
    }
}
