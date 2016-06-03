namespace UM007.DesignPatternTest.IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu[] menus = {new DinerMenu(), new PancakeHouseMenu()};
            Waitress waitress = new Waitress(menus);
            waitress.PrintMenu();
        }
    }
}
