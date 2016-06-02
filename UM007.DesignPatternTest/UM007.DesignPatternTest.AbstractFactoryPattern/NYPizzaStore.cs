namespace UM007.DesignPatternTest.AbstractFactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {
        private IPizzaIngredientFactory _ingredient = new NYPizzaIngredientFactory();

        protected override Pizza GetPizza(string pizzaType)
        {
            switch (pizzaType)
            {
                case "cheese":
                    return new CheesePizza(_ingredient);
                case"greek":
                    return new GreekPizza(_ingredient);
                default:
                    return  new CheesePizza(_ingredient);
            }
        }
    }
}
