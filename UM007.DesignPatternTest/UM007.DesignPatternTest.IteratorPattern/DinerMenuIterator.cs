namespace UM007.DesignPatternTest.IteratorPattern
{
    public class DinerMenuIterator : IIterator
    {
        private MenuItem[] _menuItems;
        private int _position = 0;
        public DinerMenuIterator(MenuItem[] menuItems)
        {
            this._menuItems = menuItems;
        }

        public bool HasNext()
        {
            if (_position > _menuItems.Length - 1 || _menuItems[_position] == null)
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
