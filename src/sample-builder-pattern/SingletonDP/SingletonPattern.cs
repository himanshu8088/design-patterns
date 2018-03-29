using System;
using System.Diagnostics;
using System.Threading.Tasks;
namespace DesignPatterns.SingletonDP
{
    public class SingletonPattern : Pattern
    {
        public SingletonPattern()
        {

        }
        public override void Run()
        {
            base.Run();
            Action a = () => CreateInstance();
            a.Invoke();
        }

        private void CreateInstance()
        {
            Singleton singleton = Singleton.Instance;
            Debug.WriteLine(singleton.GetHashCode());
        }
    }
}
