using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProtoFlipPizzaSystem.Models.Enums;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contacts
{
    interface IIgredient
    {
        string Name { get; }

        UnitType UnitType { get; }

        decimal CalculateUnitPrice();

        decimal TotalPrice { get; }

        decimal Quantity { get; }
    }
}
