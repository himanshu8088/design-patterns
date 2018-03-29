using System;
using DesignPatterns.CommandDP.Interfaces;
namespace DesignPatterns.CommandDP.Implementations
{
    public class AdditionCommand : Command
    {        
        public AdditionCommand(ICommandReceiver commandReceiver) : base(commandReceiver)
        {
        }

        public override void Execute()
        {
            commandReceiver.TakeAction();
        }

        public override void Unexecute()
        {
            commandReceiver.TakeAction();
        }
    }
}
