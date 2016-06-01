using System;

namespace UM007.DesignPatternTest.SimpleFactoryPattern
{
    public class Pizza
    {
        public virtual void Description()
        {
            Console.WriteLine("我是比萨");
        }

        public void Prepare()
        {
            Console.WriteLine("开始准备");
        }

        public void Bake()
        {
            Console.WriteLine("开始烧烤");
        }

        public void Cut()
        {
            Console.WriteLine("开始切片");
        }

        public void Box()
        {
            Console.WriteLine("开始装盒");
        }
    }
}
