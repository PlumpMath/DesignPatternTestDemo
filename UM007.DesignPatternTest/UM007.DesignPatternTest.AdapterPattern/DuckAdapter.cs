using System;

namespace UM007.DesignPatternTest.AdapterPattern
{
    public class DuckAdapter:IDuck
    {
        private IDog _dog;
        public DuckAdapter(IDog dog)
        {
            this._dog = dog;
        }

        public void Quack()
        {
            this._dog.Bark();
        }

        public void Fly()
        {
            Console.WriteLine("我就是一只不会飞的鸭子(其实我是只狗 o.o)");
        }
    }
}
