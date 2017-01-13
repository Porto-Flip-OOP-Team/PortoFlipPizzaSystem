using System;

namespace ProtoFlipPizzaSystem.Models.Validation
{
    public class CustomeException : ApplicationException
    {
        public CustomeException(string msg) : base(msg)
        {

        }
    }
}
