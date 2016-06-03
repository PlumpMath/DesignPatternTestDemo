using System;

namespace UM007.DesignPatternTest.TemplateMethodPattern
{
    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("用开水泡咖啡");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("加入牛奶与糖");
        }
    }
}
