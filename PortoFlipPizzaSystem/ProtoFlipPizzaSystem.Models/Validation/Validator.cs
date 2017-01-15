using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Exceptions;

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

        /// <summary>
        /// Checks if the number of ordered products is not zero or negative number
        /// </summary>
        /// <param name="value">the number of ordered products</param>
        /// <param name="message">the exception message</param>
        public static void ValidateOrderQuantity(int value, string message)
        {
            if (value <= 0)
            {
                throw new InvalidOrderQuantityException(message);
            }
        }

        /// <summary>
        /// Checks if the ordered product is listed in the menu
        /// </summary>
        /// <param name="list">list of all products in the menu</param>
        /// <param name="product">ordered product</param>
        /// <param name="message">the exception message</param>
        public static void ValidateMenuItem(IList<IProduct> list, IProduct product, string message)
        {
            if (!list.Contains(product))
            {
                throw new InvalidMenuItemException(message);
            }
        }
    }
}