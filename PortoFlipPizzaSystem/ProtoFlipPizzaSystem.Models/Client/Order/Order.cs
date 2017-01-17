using System.Collections.Generic;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Client.Contracts;
using ProtoFlipPizzaSystem.Models.Client.Structures;
using ProtoFlipPizzaSystem.Models.Validation;

namespace ProtoFlipPizzaSystem.Models.Client.Order
{
    public class Order : IOrder
    {
        private const string TheProductCannotBeNull = "The product cannot be null!";

        public Order(List<OrderItem> products, int quantity)
        {
            this.Products = products;
            this.IsDeleted = false;
        }

        public bool IsDeleted { get; set; }

        public List<OrderItem> Products { get; private set; }

        public void AddProduct(decimal quantity, IProduct product)
        {
            Validator.ValidateNull(product, TheProductCannotBeNull);
            this.Products.Add(new OrderItem(product, quantity));
        }

        public void DeleteProduct(IProduct product)
        {
            Validator.ValidateNull(product, TheProductCannotBeNull);
            int index = this.Products.FindIndex(item => item.OrderProduct.Name.Equals(product.Name));
            this.Products.RemoveAt(index);
        }

        public decimal CalculateTotalOrderPrice()
        {
            decimal sum = 0;
            foreach (var product in this.Products)
            {
                sum += product.Quantity * product.OrderProduct.CalculatePrice();
            }

            return sum;
        }
    }
}