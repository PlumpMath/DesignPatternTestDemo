namespace UM007.DesignPatternTest.FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade watchMovie = new HomeTheaterFacade(new Popper(), new Screen(), new CDPlayer());
            watchMovie.WatchMove();
            watchMovie.EndMove();
        }
    }
}
