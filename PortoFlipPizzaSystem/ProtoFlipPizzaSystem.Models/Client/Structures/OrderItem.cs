using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace ProtoFlipPizzaSystem.Models.Client.Structures
{
    public struct OrderItem
    {
        public OrderItem(IProduct orderProduct, decimal quantity)
        {
            this.OrderProduct = orderProduct;
            this.Quantity = quantity;
        }

        public IProduct OrderProduct { get; private set; }

        public decimal Quantity { get; private set; }
    }
}