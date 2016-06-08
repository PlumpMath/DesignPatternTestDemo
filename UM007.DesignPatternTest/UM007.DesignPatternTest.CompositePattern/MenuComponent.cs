using System;
using System.Collections;

namespace UM007.DesignPatternTest.CompositePattern
{
    public abstract class MenuComponent
    {
        public virtual string GetName()
        {
            throw new InvalidOperationException();
        }

        public virtual string GetDescription()
        {
            throw new InvalidOperationException();
        }

        public virtual double GetPrice()
        {
            throw new InvalidOperationException();
        }

        public virtual bool IsVegetarian()
        {
            throw new InvalidOperationException();
        }

        public virtual void Add(MenuComponent component)
        {
            throw new InvalidOperationException();
        }

        public virtual void Print()
        {
            throw new InvalidOperationException();
        }
    }
}