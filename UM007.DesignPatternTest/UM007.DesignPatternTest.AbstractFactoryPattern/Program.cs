namespace UM007.DesignPatternTest.AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore ps = new NYPizzaStore();
            ps.OrderPizza("cheese");
        }
    }
}
