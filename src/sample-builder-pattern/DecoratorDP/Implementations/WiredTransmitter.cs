using System;
using DesignPatterns.DecoratorDP.Interfaces;
namespace DesignPatterns.DecoratorDP.Implementations
{
    public class WiredTransmitter : ITransmitter
    {
        public WiredTransmitter()
        {
        }

        public byte[] Recieve()
        {
            throw new NotImplementedException();
        }

        public void Send(byte[] information)
        {
            throw new NotImplementedException();
        }
    }
}
