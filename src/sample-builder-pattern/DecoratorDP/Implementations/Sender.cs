using System;
using System.Diagnostics;
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
            Debug.WriteLine("Message Sent Successfully");
            return;
        }
    }
}
