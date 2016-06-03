namespace UM007.DesignPatternTest.IteratorPattern
{
    public class MenuItem
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _vegetarian;
        private readonly double _price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this._name = name;
            this._description = description;
            this._vegetarian = vegetarian;
            this._price = price;
        }

        public string GetName()
        {
            return this._name;
        }
        public string GetDescription()
        {
            return this._description;
        }
        public bool GetVegetarian()
        {
            return this._vegetarian;
        }
        public double GetPrice()
        {
            return this._price;
        }
    }
}
