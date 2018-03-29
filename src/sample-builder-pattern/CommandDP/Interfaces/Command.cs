using System;
namespace DesignPatterns.CommandDP.Interfaces
{
    public abstract class Command
    {
        protected ICommandReceiver commandReceiver;

        public Command(ICommandReceiver commandReceiver){
            this.commandReceiver = commandReceiver;   
        }

        public abstract void Execute();
        public abstract void Unexecute();
    }
}
