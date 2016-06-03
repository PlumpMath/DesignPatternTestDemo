using System;

namespace UM007.DesignPatternTest.AdapterPattern
{
    public class WildDog : IDog
    {
        public void Bark()
        {
            Console.WriteLine("我会汪汪叫");
        }

        public void Jump()
        {
            Console.WriteLine("我跳的很高");
        }
    }
}
