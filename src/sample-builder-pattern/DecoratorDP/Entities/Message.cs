using System;
namespace DesignPatterns.DecoratorDP.Entities
{
    public class Message
    {
        private byte[] _stream;
        private int _id;

        public Message(int id, byte[] stream)
        {
            this._id = id;
            this._stream = stream;
        }

        public Message(int id){
            this._id = id;
        }

        public int GetId(){
            return this._id;
        }

        public byte[] GetStream(){
            return this._stream;
        }

        public void SetStream(byte[] stream)
        {
            this._stream = stream;
        }
    }
}
