using System.Collections;

namespace UM007.DesignPatternTest.IteratorPattern
{
    public class PancakeHouseMenu : IMenu
    {
        private ArrayList _menuItems;

        public PancakeHouseMenu()
        {
            this._menuItems = new ArrayList();
            AddItem("美味早餐饼", "用鸡蛋与吐司为材料(好像不太好吃的样子)", true, 2.99);
            AddItem("常规的早餐饼", "用油炸鸡蛋与香肠为材料", true, 2.99);
            AddItem("蓝莓早餐饼", "用新鲜草莓为材料(这个 o.o )", true, 2.99);
        }

        private void AddItem(string name, string description, bool isVegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);
            this._menuItems.Add(menuItem);
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(this._menuItems);
        }

    }
}
