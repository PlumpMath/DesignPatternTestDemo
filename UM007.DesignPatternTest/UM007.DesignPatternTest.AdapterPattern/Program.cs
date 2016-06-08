namespace UM007.DesignPatternTest.AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDog dog = new WildDog();
            IDuck duck = new WildDuck();
            dog.Bark();
            duck.Quack();
            dog.Jump();
            duck.Fly();
            DuckAdapter adapterDuck = new DuckAdapter(dog);
            adapterDuck.Quack();
            adapterDuck.Fly();
        }
    }
}
