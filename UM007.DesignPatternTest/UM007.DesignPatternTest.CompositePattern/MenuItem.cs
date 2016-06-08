using System;

namespace UM007.DesignPatternTest.CompositePattern
{
    public class MenuItem : MenuComponent
    {
        private readonly string _name;
        private readonly string _description;
        private readonly double _price;
        private readonly bool _isVegetarian;

        public MenuItem(string name, string description, double price, bool isVegetarian)
        {
            _name = name;
            _description = description;
            _price = price;
            _isVegetarian = isVegetarian;
        }

        public override string GetName()
        {
            return this._name;
        }

        public override string GetDescription()
        {
            return this._description;
        }

        public override double GetPrice()
        {
            return this._price;
        }

        public override bool IsVegetarian()
        {
            return this._isVegetarian;
        }

        public override void Print()
        {
            Console.WriteLine("名字:{0}", GetName());
            Console.WriteLine("简介:{0}", GetDescription());
            Console.WriteLine("是否为素食:{0}", IsVegetarian() ? "v" : "x");
            Console.WriteLine("价格:{0}", GetPrice());
        }
    }
}
