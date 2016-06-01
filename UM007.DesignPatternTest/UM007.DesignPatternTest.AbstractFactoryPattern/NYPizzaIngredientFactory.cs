namespace UM007.DesignPatternTest.AbstractFactoryPattern
{
    class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough GetDough()
        {
            return new ThinCrustDough();
        }

        public Sauce GetSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese GetCheese()
        {
            return new ReggianoCheese();
        }
    }
}
