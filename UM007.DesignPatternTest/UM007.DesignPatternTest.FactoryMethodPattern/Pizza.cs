using System;
using System.Collections.Generic;

namespace UM007.DesignPatternTest.FactoryMethodPattern
{
    public class Pizza
    {
        protected string Name;
        protected string Dough;
        protected string Sauce;
        protected IList<string> Toppings = new List<string>();

        public Pizza()
        {
            Name = "比萨";
            Dough = "薄饼";
            Sauce = "Marinara酱";
            Toppings.Add("Regiano高级奶酪");
        }

        public virtual void Description()
        {
            Console.WriteLine("我是比萨");
        }

        public virtual void Prepare()
        {
            Console.WriteLine("开始准备{0}", Name);
            Console.WriteLine("开始活面...");
            Console.WriteLine("加入调料酱...");
            Console.WriteLine("添加配料: ");
            foreach (string topping in Toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("开始烧烤");
        }

        public virtual void Cut()
        {
            Console.WriteLine("开始切片");
        }

        public virtual void Box()
        {
            Console.WriteLine("开始装盒");
        }

        public string GetName()
        {
            return Name;
        }
    }
}
