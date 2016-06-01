using System;
using System.Collections.Generic;

namespace UM007.DesignPatternTest.AbstractFactoryPattern
{
    public abstract class Pizza
    {
        protected string Name;
        protected Dough Dough;
        protected Sauce Sauce;
        protected Cheese Cheese;

        public Pizza()
        {
            Name = "比萨";
        }

        public virtual void Description()
        {
            Console.WriteLine("我是比萨");
        }

        public abstract void Prepper();

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
