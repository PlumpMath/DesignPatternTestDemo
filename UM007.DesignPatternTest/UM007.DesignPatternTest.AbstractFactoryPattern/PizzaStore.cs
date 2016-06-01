namespace UM007.DesignPatternTest.AbstractFactoryPattern
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string pizzaType = " ")
        {
            Pizza pizza = GetPizza(pizzaType);
            pizza.Prepper();
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
        protected abstract Pizza GetPizza(string pizzaType);
    }
}
