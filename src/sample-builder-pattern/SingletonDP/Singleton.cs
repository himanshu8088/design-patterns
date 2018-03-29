namespace DesignPatterns.SingletonDP
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        private Singleton()
        {
        }

        static Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
