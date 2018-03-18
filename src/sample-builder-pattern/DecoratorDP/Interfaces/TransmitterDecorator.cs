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

        public virtual byte[] Recieve()
        {
            return Transmitter.Recieve();
        }

        public virtual void Send(byte[] information)
        {
            Transmitter.Send(information);
        }
    }
}
