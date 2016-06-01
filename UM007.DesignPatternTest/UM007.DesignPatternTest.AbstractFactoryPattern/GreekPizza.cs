using System;

namespace UM007.DesignPatternTest.AbstractFactoryPattern
{
    public class GreekPizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;
        public GreekPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
            Name = "纽约式希腊比萨";
        }
        public override void Description()
        {
            Console.WriteLine("我是纽约式希腊比萨");
        }

        public override void Prepper()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = this._ingredientFactory.GetDough();
            Sauce = this._ingredientFactory.GetSauce();
            Cheese = this._ingredientFactory.GetCheese();
        }
    }
}
