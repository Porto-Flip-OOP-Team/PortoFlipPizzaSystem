using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoFlipPizzaSystem.Models.Administrator.Abstract;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class Customer : Person, ICustomer
    {
        private const double MAX_DISCOUNT = 20;
        private double discount;
        public Customer(string firstName, string lastName, string address) : base(firstName, lastName, address)
        {
        }

        public Customer(string firstName, string lastName, string address, double discount) : base(firstName, lastName, address)
        {
            this.Discount = discount;
        }

        public double Discount
        {
            get
            {
                return this.discount;
            }
            private set
            {
                if (value > 20)
                {
                    this.discount = MAX_DISCOUNT;
                }
                else
                {
                    this.discount = value;
                }
            }
        }
        public int NumberOfOrders { get; private set; }

        protected override string GetPrefix()
        {
            return "CL";
        }
    }
}
