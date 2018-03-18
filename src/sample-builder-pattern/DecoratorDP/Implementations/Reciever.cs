using System;
using DesignPatterns.DecoratorDP.Interfaces;
namespace DesignPatterns.DecoratorDP.Implementations
{
    public class Reciever:IReceiver
    {
        public Reciever()
        {
        }

        public byte[] Receive()
        {
            throw new NotImplementedException();
        }
    }
}
