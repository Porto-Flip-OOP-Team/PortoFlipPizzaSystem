using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;


namespace ProtoFlipPizzaSystem.Models.Administrator.Abstract
{
    public abstract class Product : IProduct
    {
        public string Name { get; private set; }

        public bool IsDeleted { get; private set; } = false;

        public Product(string name)
        {
            this.Name = name;
        }

        public abstract decimal CalculatePrice();

        public void Delete()
        {
            this.IsDeleted = true;
        }
    }
}
