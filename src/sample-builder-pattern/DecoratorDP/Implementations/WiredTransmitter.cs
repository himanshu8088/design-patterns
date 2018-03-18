using System;
using DesignPatterns.DecoratorDP.Interfaces;
namespace DesignPatterns.DecoratorDP.Implementations
{
    public class WiredTransmitter : ITransmitter
    {
        private ISender _sender;
        private IReceiver _receiver;

        public WiredTransmitter(ISender sender, IReceiver receiver)
        {
            _sender = sender;
            _receiver = receiver;
        }

        public byte[] Recieve()
        {
            var stream = _receiver.Receive();
            return stream;
        }

        public void Send(byte[] stream)
        {
            _sender.Send(stream);
        }
    }
}
