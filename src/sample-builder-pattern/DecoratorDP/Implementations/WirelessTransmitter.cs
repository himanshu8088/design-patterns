using System;
using DesignPatterns.DecoratorDP.Interfaces;
namespace DesignPatterns.DecoratorDP.Implementations
{
    public class WirelessTransmitter : ITransmitter
    {
        public WirelessTransmitter()
        {
        }

        public byte[] Recieve()
        {
            throw new NotImplementedException();
        }

        public void Send(byte[] stream)
        {
            throw new NotImplementedException();
        }
    }
}
