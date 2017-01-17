using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Structures
{
    public struct ProductItem
    {
        public ProductItem(IIngredient ingredient, decimal quantity)
        {
            this.Igredient = ingredient;
            this.Quantity = quantity;
        }

        public IIngredient Igredient { get; private set; }

        public decimal Quantity { get; private set; }
    }
}
