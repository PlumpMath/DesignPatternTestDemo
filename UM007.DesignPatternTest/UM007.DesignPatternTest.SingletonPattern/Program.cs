using System;

namespace UM007.DesignPatternTest.SingletonPattern
{
    static class Program
    {
        static void Main()
        {
            SingletonPatternEagerly singleEagerly = SingletonPatternEagerly.GetInstance();
            SingletonPatternLazy singleLazy = SingletonPatternLazy.GetInstance();
            TestClass testClass = new TestClass();
            Console.WriteLine(singleEagerly.GetHashCode());
            Console.WriteLine(singleLazy.GetHashCode());
            Console.WriteLine(testClass.GetHashCode());
            singleEagerly = SingletonPatternEagerly.GetInstance();
            singleLazy = SingletonPatternLazy.GetInstance();
            testClass = new TestClass();
            Console.WriteLine(singleEagerly.GetHashCode());
            Console.WriteLine(singleLazy.GetHashCode());
            Console.WriteLine(testClass.GetHashCode());
        }
    }
}
