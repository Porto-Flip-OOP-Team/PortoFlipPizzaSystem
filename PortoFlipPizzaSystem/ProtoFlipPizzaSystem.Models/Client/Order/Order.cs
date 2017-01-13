using ProtoFlipPizzaSystem.Models.Client.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace ProtoFlipPizzaSystem.Models.Client.Order
{
    class Order : IOrder
    {

        private IProduct product;
        private int quantity;

        public Order(IProduct product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

        public IProduct Product
        {
            get
            {
                return this.product;
            }
            set
            {
                //Some validation whether the product exists in the menu
                this.product = value;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The quantity of product must be a positive number");
                }
                this.quantity = value;
            }
        }

        public decimal TotalProductPrice
        {
            get
            {
                return Product.calculatePrice() * quantity;
            }
        }

          public decimal CalculateTotalOrderPrice(List<IOrder> order)
        {
            decimal sum = 0;
            foreach (var element in order)
            {
                sum += element.TotalProductPrice;
            }
            return sum;
        }
    }
}
