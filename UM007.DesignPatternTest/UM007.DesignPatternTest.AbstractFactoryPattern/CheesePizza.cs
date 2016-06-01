using System;

namespace UM007.DesignPatternTest.AbstractFactoryPattern
{
    public class CheesePizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;
        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
            Name = "纽约式奶酪比萨";
        }
        public override void Description()
        {
            Console.WriteLine("我是纽约式奶酪比萨");
        }

        public override void Prepper()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = this._ingredientFactory.GetDough();
            this._ingredientFactory.GetDough().ShowDescription();
            Sauce = this._ingredientFactory.GetSauce();
            this._ingredientFactory.GetSauce().ShowDescription();
            Cheese = this._ingredientFactory.GetCheese();
            this._ingredientFactory.GetCheese().ShowDescription();
        }

        public override void Cut()
        {
            Console.WriteLine("我把它切成五角形");
        }
    }
}
