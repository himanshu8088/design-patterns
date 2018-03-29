using System;
using DesignPatterns.DecoratorDP.Entities;
using DesignPatterns.DecoratorDP.Implementations;
using DesignPatterns.DecoratorDP.Interfaces;
namespace DesignPatterns.DecoratorDP
{
    public class DecoratorPattern : Pattern
    {
        public override void Run()
        {
            base.Run();
            Message message = GetMessage();
            ITransmitter transmitter = GetLoggableTransmitter();
            transmitter.Send(message.GetStream());
            var stream = transmitter.Recieve();
        }

        private ITransmitter GetLoggableTransmitter()
        {
            ILogger logger = GetLogger();
            ITransmitter transmitter = GetTransmitter();
            return new LoggableTransmitter(logger, transmitter);
        }

        private ITransmitter GetTransmitter()
        {
            ISender sender = GetSender();
            IReceiver reciever = GetReciever();
            return new WiredTransmitter(sender, reciever);
        }

        private IReceiver GetReciever()
        {
            return new Reciever();
        }

        private ISender GetSender()
        {
            return new Sender();
        }

        private ILogger GetLogger()
        {
            return new Logger();
        }

        private Message GetMessage()
        {
            var message = new Message(101);
            message.SetStream(new byte[]{01,10});
            return message;
        }
    }
}
