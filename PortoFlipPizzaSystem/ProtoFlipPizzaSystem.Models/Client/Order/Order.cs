using ProtoFlipPizzaSystem.Models.Client.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Client.Structures;

namespace ProtoFlipPizzaSystem.Models.Client.Order
{
   public class Order : IOrder
    {

        public Order(List<OrderItem> products, int quantity)
        {
            this.Products = products;
        }

        public bool IsDeleted { get; private set; } = false;

        public List<OrderItem> Products { get; private set; }

        public void AddProduct(decimal quantity, IProduct product)
        {
            this.Products.Add(new OrderItem(product, quantity));
        }

        public void DeleteProduct(IProduct product)
        {
            int index = this.Products.FindIndex(item => item.OrderProduct.Name.Equals(product.Name));
            this.Products.RemoveAt(index);
        }


        public decimal CalculateTotalOrderPrice()
        {
            decimal sum = 0;
            foreach (var product in Products)
            {
                sum += product.Quantity * product.OrderProduct.CalculatePrice();
            }
            return sum;
        }

        public void Delete()
        {
            this.IsDeleted = true;
        }
    }
}
