using System;

namespace UM007.DesignPatternTest.IteratorPattern
{
    public interface IIterator
    {
        bool HasNext();

        Object Next();
    }
}
