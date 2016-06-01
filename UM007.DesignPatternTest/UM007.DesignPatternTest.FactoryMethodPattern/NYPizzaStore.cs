namespace UM007.DesignPatternTest.FactoryMethodPattern
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza GetPizza(string pizzaType)
        {
            switch (pizzaType)
            {
                case "cheese":
                    return new NYCheesePizza();
                case"greek":
                    return new NYGreekPizza();
                default:
                    return new Pizza();
            }
        }
    }
}
