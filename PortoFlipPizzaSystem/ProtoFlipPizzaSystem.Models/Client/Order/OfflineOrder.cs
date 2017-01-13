using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Validation;

namespace ProtoFlipPizzaSystem.Models.Client.Order
{
    class OfflineOrder : Order
    {
        private int numberOfTable;

        public OfflineOrder(IProduct product, int quantity, int numberOfTable) : base(product, quantity)
        {
            this.NumberOfTable = numberOfTable;
        }

        public int NumberOfTable
        {
            get
            {
                return this.numberOfTable;
            }
            private set
            {
                //Our pizza restaurant has 50 tables
                Validator.ValidateIntRange(value, 1, 50, "There's no such number of table.");
                this.numberOfTable = value;
            }
        }
    }
}
