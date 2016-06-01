namespace UM007.DesignPatternTest.FactoryMethodPattern
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string pizzaType = " ")
        {
            Pizza pizza = GetPizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            pizza.Description();
            return pizza;
        }
        /// <summary>
        /// 工厂方法(:boom:)
        /// </summary>
        /// <param name="pizzaType"></param>
        /// <returns></returns>
        public abstract Pizza GetPizza(string pizzaType);
    }
}
