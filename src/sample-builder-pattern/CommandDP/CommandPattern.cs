using System;
using DesignPatterns.CommandDP.Interfaces;
using DesignPatterns.CommandDP.Implementations;
namespace DesignPatterns.CommandDP
{
    public class CommandPattern:Pattern
    {
        public CommandPattern()
        {
        }

        public override void Run(){
            base.Run();
            ICommandReceiver calculator = new Calulator();
            Command addCommand = new AdditionCommand(calculator);

            ICommandInvoker client = new Client();
            client.Invoke(addCommand);
        }
    }
}
