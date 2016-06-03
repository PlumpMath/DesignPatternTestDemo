using System;

namespace UM007.DesignPatternTest.AdapterPattern
{
    public class WildDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("我会呱呱叫");
        }

        public void Fly()
        {
            Console.WriteLine("我会飞呀");
        }
    }
}
