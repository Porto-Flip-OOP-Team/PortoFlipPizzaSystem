using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Client.Structures;

namespace ProtoFlipPizzaSystem.Models.Client.Order
{
    class OnlineOrder : Order
    {
        public OnlineOrder(List<OrderItem> products, int quantity, string comment) : base(products, quantity)
        {
            this.Comment = comment;
            this.Time = DateTime.Now;
        }

        public string Comment { get; private set; }
        public DateTime Time { get; private set; }
    }
}
