using System;
using DesignPatterns.CommandDP.Interfaces;
using System.Diagnostics;
namespace DesignPatterns.CommandDP.Implementations
{
    public class Calulator: ICommandReceiver
    {
        public Calulator()
        {
        }

        public void TakeAction()
        {
            Debug.WriteLine("Calculator has taken action after receiving command.");
        }
    }
}
