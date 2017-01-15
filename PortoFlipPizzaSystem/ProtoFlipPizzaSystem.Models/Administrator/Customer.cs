using ProtoFlipPizzaSystem.Models.Administrator.Abstract;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class Customer : Person, IPerson, ICustomer, IDeletable, IIdentifiable
    {
        private const decimal MAX_DISCOUNT = 20;
        private decimal discount;

        public Customer(string firstName, string lastName, string address) : base(firstName, lastName, address)
        {
        }
        public Customer(string firstName, string lastName, string address, decimal discount) : base(firstName, lastName, address)
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

        public int NumberOfOrders { get;  set; }
    }
}
