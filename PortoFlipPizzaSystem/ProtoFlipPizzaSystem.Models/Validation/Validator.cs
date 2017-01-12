using System;
using System.Text.RegularExpressions;

namespace ProtoFlipPizzaSystem.Models.Validation
{
    public static class Validator
    {
        /// <summary>
        /// Checks if the given integer number is between the required range
        /// </summary>
        /// <param name="value">integer number</param>
        /// <param name="min">the minimal range</param>
        /// <param name="max">the maxixmum range</param>
        /// <param name="message">the exception message</param>
        public static void ValidateIntRange(int value, int min, int max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// Checks if given decimal number is between the required range
        /// </summary>
        /// <param name="value">value as decimal number</param>
        /// <param name="min">the minimal range</param>
        /// <param name="max">the maxixmum range</param>
        /// <param name="message">the exception message</param>
        public static void ValidateDecimalRange(decimal value, decimal min, decimal max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// Checks if the given object is null or not
        /// </summary>
        /// <param name="value">the object</param>
        /// <param name="message">the exception message</param>
        public static void ValidateNull(object value, string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }
        }

        /// <summary>
        /// Checks if the symbols are valid for different verifications
        /// </summary>
        /// <param name="value">value as string</param>
        /// <param name="pattern">pattern for validation</param>
        /// <param name="message">the exception message</param>
        public static void ValidateSymbols(string value, string pattern, string message)
        {
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);

            if (!regex.IsMatch(value))
            {
                throw new ArgumentException(message);
            }
        }
    }
}