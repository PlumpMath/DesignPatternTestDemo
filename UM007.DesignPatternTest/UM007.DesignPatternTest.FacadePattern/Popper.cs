using System;

namespace UM007.DesignPatternTest.FacadePattern
{
    public class Popper
    {
        public void On()
        {
            Console.WriteLine("打开了爆米花机");
        }

        public void Off()
        {
            Console.WriteLine("关闭了爆米花机");
        }

        public void Pop()
        {
            Console.WriteLine("开始制作爆米花");
        }
    }
}
