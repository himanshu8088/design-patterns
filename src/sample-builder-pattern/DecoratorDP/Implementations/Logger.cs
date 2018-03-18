using System;
using DesignPatterns.DecoratorDP.Interfaces;
namespace DesignPatterns.DecoratorDP.Implementations
{
    public class Logger : ILogger
    {
        public Logger() 
        {
        }

        public void Log(string information)
        {
            throw new NotImplementedException();
        }
    }
}
