using System;
using DesignPatterns.DecoratorDP.Interfaces;
namespace DesignPatterns.DecoratorDP.Implementations
{
    public class LoggableTransmitter : TransmitterDecorator
    {
        private ILogger _logger;

        public LoggableTransmitter(ILogger logger,ITransmitter transmitter) : base(transmitter)
        {
            _logger = logger;
        }

        public override byte[] Recieve()
        {
            var stream = base.Recieve();
            _logger.Log($"Data recieved successfully at {DateTime.Now}");
            return stream;
        }

        public override void Send(byte[] information)
        {
            base.Send(information);
            _logger.Log($"Data sent successfully at {DateTime.Now}");
        }
    }
}
