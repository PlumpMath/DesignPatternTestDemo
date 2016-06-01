namespace UM007.DesignPatternTest.AbstractFactoryPattern
{
    public interface IPizzaIngredientFactory
    {
        Dough GetDough();

        Sauce GetSauce();

        Cheese GetCheese();
    }
}
