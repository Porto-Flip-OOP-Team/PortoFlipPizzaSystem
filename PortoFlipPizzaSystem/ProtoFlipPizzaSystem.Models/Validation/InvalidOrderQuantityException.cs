using System;

namespace ProtoFlipPizzaSystem.Models.Validation
{
    public class InvalidOrderQuantityException : ArgumentException
    {
        public InvalidOrderQuantityException()
        {
        }

        public InvalidOrderQuantityException(string msg) : base(msg)
        {
        }

        public InvalidOrderQuantityException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}