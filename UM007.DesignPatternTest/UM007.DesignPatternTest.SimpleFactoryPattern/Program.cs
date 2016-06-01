namespace UM007.DesignPatternTest.SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore ps = new PizzaStore(factory);
            ps.OrderPizza("cheese");
            ps.OrderPizza("greek");
        }
    }
}
