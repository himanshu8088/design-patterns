using System;
using DesignPatterns.DecoratorDP.Interfaces;
using System.Diagnostics;
namespace DesignPatterns.DecoratorDP.Implementations
{
    public class Logger : ILogger
    {
        public Logger() 
        {
        }

        public void Log(string information)
        {
            Debug.WriteLine($"Logged successfully: {information}");
        }
    }
}
