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
            this.Time = DateTime.Now;
        }

        public OnlineOrder(IProduct product, int quantity, string comment) : base(product, quantity)
        {
            this.Comment = comment;
            this.Time = DateTime.Now;
        }

        public string Comment { get; private set; }
        public DateTime Time { get; private set; }
    }
}
