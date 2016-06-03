using System;
using System.Collections.Generic;

namespace UM007.DesignPatternTest.IteratorPattern
{
    public class Waitress
    {
        private IList<IMenu> _menus;

        public Waitress(IList<IMenu> menus)
        {
            _menus = menus;
        }

        public void PrintMenu()
        {
            foreach (IMenu menu in this._menus)
            {
                PrintMenu(menu.CreateIterator());
            }
        }

        private void PrintMenu(IIterator menu)
        {
            while (menu.HasNext())
            {
                MenuItem menuItem = (MenuItem)menu.Next();
                Console.WriteLine("{0}\r\n{1}\r\n{2}",menuItem.GetName(), menuItem.GetDescription(),menuItem.GetPrice());
            }
        }
    }
}
