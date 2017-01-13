using System;

namespace ProtoFlipPizzaSystem.Models.Validation
{
    public class InvalidOrderException : ApplicationException
    {
        public InvalidOrderException(string msg) : base(msg)
        {
        }
    }
}