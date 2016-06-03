using System;

namespace UM007.DesignPatternTest.FacadePattern
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("升起了屏幕");
        }

        public void Down()
        {
            Console.WriteLine("放下了屏幕");
        }
    }
}
