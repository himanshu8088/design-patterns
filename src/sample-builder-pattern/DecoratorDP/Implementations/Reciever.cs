using System;
using DesignPatterns.DecoratorDP.Interfaces;
using System.Diagnostics;
namespace DesignPatterns.DecoratorDP.Implementations
{
    public class Reciever:IReceiver
    {
        public Reciever()
        {
        }

        public byte[] Receive()
        {
            Debug.WriteLine("Message Received Successfully");
            return new byte[] { 00, 01};
        }
    }
}
