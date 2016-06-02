namespace UM007.DesignPatternTest.SingletonPattern
{
    public class SingletonPatternLazy
    {
        private static SingletonPatternLazy _singleInstance;
        private static readonly object Locker = new object();

        private SingletonPatternLazy() { }

        public static SingletonPatternLazy GetInstance()
        {
            if (_singleInstance == null)
            {
                lock(Locker)
                {
                    if (_singleInstance == null)
                    {
                        _singleInstance = new SingletonPatternLazy();
                    }
                }
            }
            return _singleInstance;
        }
    }
}
