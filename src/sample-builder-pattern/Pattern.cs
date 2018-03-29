using System;
using System.Diagnostics;
namespace DesignPatterns
{
    public abstract class Pattern
    {
        public Pattern()
        {
        }

        public virtual void Run(){
            Debug.WriteLine($"\n {this.GetType().FullName} \n");
        }
    }
}
