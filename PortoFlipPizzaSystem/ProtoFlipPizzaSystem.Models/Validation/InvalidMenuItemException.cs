﻿using System;

namespace ProtoFlipPizzaSystem.Models.Validation
{
    public class InvalidMenuItemException : ArgumentException
    {
        public InvalidMenuItemException()
        {
        }

        public InvalidMenuItemException(string message) : base(message)
        {
        }

        public InvalidMenuItemException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}