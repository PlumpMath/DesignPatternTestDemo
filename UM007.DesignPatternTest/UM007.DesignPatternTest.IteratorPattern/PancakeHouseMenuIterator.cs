using System.Collections;

namespace UM007.DesignPatternTest.IteratorPattern
{
    public class PancakeHouseMenuIterator : IIterator
    {
        private ArrayList _menuItems;
        private int _position = 0;

        public PancakeHouseMenuIterator(ArrayList menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {
            if (_position > _menuItems.Count - 1 || _menuItems[_position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            return _menuItems[_position++];
        }
    }
}
