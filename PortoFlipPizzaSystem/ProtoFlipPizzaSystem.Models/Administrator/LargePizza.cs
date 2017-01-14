﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Administrator.Abstract;
using ProtoFlipPizzaSystem.Models.Administrator.Structures;

namespace ProtoFlipPizzaSystem.Models.Administrator
{

    public class LargePizza : Pizza, IPizza
    {
        public const int NUMBER_OF_SLICES = 12;

        public LargePizza(string name, List<ProductItem> ingredients) : base(name, ingredients)
        {

        }
        public LargePizza(int id, string name, List<ProductItem> ingredients) : base(id, name, ingredients)
        {

        }

        public override string ToString()
        {
            StringBuilder visualization = new StringBuilder();
            visualization.AppendLine($"Large {this.Name}");
            visualization.AppendLine($"{NUMBER_OF_SLICES} slices");
            visualization.Append($"Price: {this.CalculatePrice()}");

            return visualization.ToString();
        }
    }
}
