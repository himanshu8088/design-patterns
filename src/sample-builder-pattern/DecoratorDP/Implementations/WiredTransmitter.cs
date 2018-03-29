using System;
using DesignPatterns.DecoratorDP.Interfaces;
using System.Diagnostics;
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
            Debug.WriteLine("Logged recieved message from wired transmitter");
            var stream = _receiver.Receive();
            return stream;
        }

        public void Send(byte[] stream)
        {
            Debug.WriteLine("Logged sent message from wired transmitter");
            _sender.Send(stream);
        }
    }
}
