using System.Collections.Generic;

using ProtoFlipPizzaSystem.Models.Client.Structures;
using ProtoFlipPizzaSystem.Models.Validation;

namespace ProtoFlipPizzaSystem.Models.Client.Order
{
    public class OfflineOrder : Order
    {
        private int numberOfTable;

        public OfflineOrder(List<OrderItem> products, int quantity, int numberOfTable)
            : base(products, quantity)
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
                // Our pizza restaurant has 50 tables
                Validator.ValidateIntRange(value, 1, 50, "There's no such number of table.");
                this.numberOfTable = value;
            }
        }
    }
}
