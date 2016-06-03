using System;

namespace UM007.DesignPatternTest.IteratorPattern
{
    public class DinerMenu : IMenu
    {
        private const int MaxItems = 6;
        private int _numberOfItems = 0;
        private MenuItem[] _menuItems;

        public DinerMenu()
        {
            this._menuItems = new MenuItem[MaxItems];
            AddItem("蔬菜三明治", "用生菜，西红柿，与小麦为主材", true, 2.99);
            AddItem("热狗", "一个热狗，开胃小菜，上层加奶酪", false, 2.99);
            AddItem("三明治", "腊肉，生菜，西红柿与小麦", true, 2.99);

        }

        private void AddItem(string name, string description, bool isVegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);
            if (this._numberOfItems > MaxItems)
            {
                Console.WriteLine("抱歉,菜单已满，不能添加");
            }
            else
            {
                this._menuItems[this._numberOfItems++] = menuItem;
            }
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(this._menuItems);
        }
    }
}
