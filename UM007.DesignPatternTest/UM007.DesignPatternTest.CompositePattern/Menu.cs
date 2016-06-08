using System;
using System.Collections;

namespace UM007.DesignPatternTest.CompositePattern
{
    public class Menu : MenuComponent
    {
        private readonly ArrayList _menuComponents = new ArrayList();
        private readonly string _name;
        private readonly string _description;

        public Menu(string name, string description)
        {
            this._name = name;
            this._description = description;
        }

        public override void Add(MenuComponent component)
        {
            this._menuComponents.Add(component);
        }

        public override string GetName()
        {
            return this._name;
        }

        public override string GetDescription()
        {
            return this._description;
        }

        public override void Print()
        {
            Console.WriteLine("名字:{0}", GetName());
            Console.WriteLine("简介:{0}", GetDescription());
            foreach (MenuComponent component in this._menuComponents)
            {
                component.Print();
            }
        }
    }
}
