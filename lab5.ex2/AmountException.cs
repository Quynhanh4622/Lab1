using System;

namespace lab5.ex2
{
    public class AmountException : Exception
    {
        public AmountException()
        {
        }
        public AmountException(string message): base(message){}
    }
}
