using System;
namespace Observer_Pattern
{
    public class FallsIllEventArgs : EventArgs
    {
        public readonly string Address;
        public FallsIllEventArgs(string address)
        {
            this.Address = address;
        }
    }
}