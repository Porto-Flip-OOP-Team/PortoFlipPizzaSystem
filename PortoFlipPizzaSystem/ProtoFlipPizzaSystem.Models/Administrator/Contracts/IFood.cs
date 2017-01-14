﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IFood : IProduct
    {
        void AddIngredient(decimal quantity, IIngredient ingredient);
        void RemoveIngredient(IIngredient ingredient);
    }
}
