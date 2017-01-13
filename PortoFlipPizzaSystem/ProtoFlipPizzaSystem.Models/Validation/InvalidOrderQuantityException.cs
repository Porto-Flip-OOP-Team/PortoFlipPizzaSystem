using System;

namespace ProtoFlipPizzaSystem.Models.Validation
{
    public class InvalidOrderQuantityException : ApplicationException
    {
        public InvalidOrderQuantityException(string msg) : base(msg)
        {
        }
    }
}