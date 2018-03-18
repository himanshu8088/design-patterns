using System;
using DesignPatterns.DecoratorDP.Interfaces;
namespace DesignPatterns.DecoratorDP.Implementations
{
    public class Sender: ISender
    {
        public Sender()
        {
        }

        public void Send(byte[] stream)
        {
            throw new NotImplementedException();
        }
    }
}
