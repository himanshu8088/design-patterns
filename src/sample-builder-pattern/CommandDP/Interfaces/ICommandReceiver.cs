using System;
using System.Security.Cryptography.X509Certificates;
namespace DesignPatterns.CommandDP.Interfaces
{
    public interface ICommandReceiver
    {
        void TakeAction();
    }
}
