using System;
using DesignPatterns.DecoratorDP.Interfaces;
namespace DesignPatterns.DecoratorDP.Implementations
{
    public class LoggableTransmitter : TransmitterDecorator
    {
        private ILogger _logger;

        public LoggableTransmitter(ILogger logger, ITransmitter transmitter) : base(transmitter)
        {
            _logger = logger;
        }

        public override byte[] Recieve()
        {
            var stream = Transmitter.Recieve();
            _logger.Log($"Data recieved successfully at {DateTime.Now} into loggable transmitter");
            return stream;
        }

        public override void Send(byte[] information)
        {
            Transmitter.Send(information);
            _logger.Log($"Data sent successfully at {DateTime.Now} from loggable transmitter");
        }
    }
}
