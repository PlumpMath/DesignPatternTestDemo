namespace UM007.DesignPatternTest.CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent dessertMenu = new Menu("甜点菜单", "我是专门做甜点的 o.o");
            MenuComponent cafeMenu = new Menu("咖啡菜单", "我是专门做咖啡的 o.o");
            MenuComponent dinnerMenu = new Menu("晚餐菜单", "我是专门做晚餐的 o.o");
            MenuComponent pancakeMenu = new Menu("馅饼菜单", "我是做馅饼的 o.o");
            MenuComponent allMenu = new Menu("所有菜单", "所有菜单的组合");

            dinnerMenu.Add(dessertMenu);
            dinnerMenu.Add(new MenuItem("美味早餐饼", "用鸡蛋与吐司为材料(好像不太好吃的样子)", 2.99, true));

            allMenu.Add(cafeMenu);
            allMenu.Add(dinnerMenu);
            allMenu.Add(pancakeMenu);

            Waitress waitress = new Waitress(allMenu);
            waitress.PrintMenu();
        }
    }
}
