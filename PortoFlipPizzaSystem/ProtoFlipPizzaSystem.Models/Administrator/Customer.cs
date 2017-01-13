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
        private const decimal MAX_DISCOUNT = 20;
        private decimal discount;
        public Customer(string firstName, string lastName, string address) : base(firstName, lastName, address)
        {
        }

        public Customer(int idPerson, string firstName, string lastName, string address) : base(idPerson, firstName, lastName, address)
        {
        }

        public Customer(string firstName, string lastName, string address, decimal discount) : base(firstName, lastName, address)
        {
            this.Discount = discount;
        }
        public Customer(int idPerson, string firstName, string lastName, string address, decimal discount) : base(idPerson, firstName, lastName, address)
        {
            this.Discount = discount;
        }

        public decimal Discount
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

    }
}
