using System;
namespace DesignPatterns.CommandDP.Interfaces
{
    public interface ICommandInvoker
    {
        void Invoke(Command command);
    }
}
