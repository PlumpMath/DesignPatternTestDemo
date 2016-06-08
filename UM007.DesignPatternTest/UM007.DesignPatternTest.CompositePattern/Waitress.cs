using System.Collections;

namespace UM007.DesignPatternTest.CompositePattern
{
    public class Waitress
    {
        private readonly MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this._allMenus = allMenus;
        }

        public void PrintMenu()
        {
            this._allMenus.Print();
        }
    }
}
