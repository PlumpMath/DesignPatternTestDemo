namespace UM007.DesignPatternTest.SimpleFactoryPattern
{
    class PizzaStore
    {
        private SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this._factory = factory;
        }

        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = this._factory.GetPizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            pizza.Description();
            return pizza;
        }
    }
}
