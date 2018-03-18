using System;
namespace DesignPatterns.DecoratorDP.Interfaces
{
    public interface ITransmitter
    {
        void Send(byte[] stream);
        byte[] Recieve();
    }
}
