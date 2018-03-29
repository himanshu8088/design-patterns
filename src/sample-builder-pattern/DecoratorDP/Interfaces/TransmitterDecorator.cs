using System;

namespace DesignPatterns.DecoratorDP.Interfaces
{
    public abstract class TransmitterDecorator: ITransmitter
    {
        protected ITransmitter Transmitter;

        public TransmitterDecorator(ITransmitter transmitter)
        {
            Transmitter = transmitter;
        }

        public abstract byte[] Recieve();

        public abstract void Send(byte[] information);
    }
}
