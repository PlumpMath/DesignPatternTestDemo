using System;

namespace UM007.DesignPatternTest.TemplateMethodPattern
{
    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (ConfirmAddCondiments())
            {
                AddCondiments();
            }
        }

        protected virtual bool ConfirmAddCondiments()
        {
            return true;
        }


        private void BoilWater()
        {
            Console.WriteLine("烧水");
        }

        protected abstract void Brew();

        private void PourInCup()
        {
            Console.WriteLine("将饮料倒入杯子");
        }

        protected abstract void AddCondiments();
    }
}
