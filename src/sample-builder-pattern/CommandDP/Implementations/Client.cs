using System;
using DesignPatterns.CommandDP.Interfaces;
using System.Diagnostics;
namespace DesignPatterns.CommandDP.Implementations
{
    public class Client: ICommandInvoker
    {
        public Client()
        {
        }

        public void Invoke(Command command)
        {
            Debug.WriteLine("Client has invoked command");
            command.Execute();
        }
    }
}
