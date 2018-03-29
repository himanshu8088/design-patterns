using System;
using DesignPatterns.DecoratorDP.Interfaces;
namespace DesignPatterns.DecoratorDP.Implementations
{
    public class WirelessTransmitter : ITransmitter
    {
        private byte[] _stream;

        public WirelessTransmitter()
        {
            _stream = new byte[] { };
        }

        public byte[] Recieve()
        {
            return _stream;
        }

        public void Send(byte[] stream)
        {
            _stream = stream;
        }
    }
}
