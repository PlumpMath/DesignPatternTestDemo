using System;

namespace UM007.DesignPatternTest.TemplateMethodPattern
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("用开水泡茶");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("加入柠檬");
        }

        protected override bool ConfirmAddCondiments()
        {
            Console.Write("需不需要加调味剂(y/n)?");
            string addCondiments = Console.ReadLine().ToUpper();
            return addCondiments.Equals("Y");
        }
    }
}
