using System;

namespace UM007.DesignPatternTest.TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();
            tea.PrepareRecipe();
            coffee.PrepareRecipe();
        }
    }
}
