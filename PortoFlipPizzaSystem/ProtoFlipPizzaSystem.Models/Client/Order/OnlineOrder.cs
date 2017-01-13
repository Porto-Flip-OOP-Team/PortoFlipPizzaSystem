using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace ProtoFlipPizzaSystem.Models.Client.Order
{
    class OnlineOrder : Order
    {
        public OnlineOrder(IProduct product, int quantity) : base(product, quantity)
        {
        }

        public OnlineOrder(string comment, IProduct product, int quantity) : base(product, quantity)
        {
            this.Comment = comment;
        }

        public string Comment { get; private set; }
    }
}
