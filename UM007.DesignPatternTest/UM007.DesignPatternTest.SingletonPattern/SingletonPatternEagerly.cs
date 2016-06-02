namespace UM007.DesignPatternTest.SingletonPattern
{
    public class SingletonPatternEagerly
    {
        private static SingletonPatternEagerly _singletonInstance = new SingletonPatternEagerly();
        private SingletonPatternEagerly() { }

        public static SingletonPatternEagerly GetInstance()
        {
            return _singletonInstance;
        }
    }
}
