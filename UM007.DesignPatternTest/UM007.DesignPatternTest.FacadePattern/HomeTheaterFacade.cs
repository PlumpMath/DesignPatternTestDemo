namespace UM007.DesignPatternTest.FacadePattern
{
    public class HomeTheaterFacade
    {
        private Popper _popper;
        private Screen _screen;
        private CDPlayer _cdPlayer;

        public HomeTheaterFacade(Popper popper, Screen screen, CDPlayer cdPlayer)
        {
            this._popper = popper;
            this._screen = screen;
            this._cdPlayer = cdPlayer;
        }

        public void WatchMove()
        {
            this._popper.On();
            this._popper.Pop();
            this._screen.Down();
            this._cdPlayer.On();
        }

        public void EndMove()
        {
            this._popper.Off();
            this._screen.Up();
            this._cdPlayer.Off();
        }
    }
}
