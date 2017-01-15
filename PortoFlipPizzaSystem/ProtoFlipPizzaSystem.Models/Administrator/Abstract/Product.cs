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
        protected static int idCounter = 1;

        public Product(string name)
        {
            this.IdProduct = this.GenerateId();
            this.Name = name;
        }
        public Product(int idProduct, string name)
        {
            this.Name = name;
            this.IdProduct = idProduct;
        }

        public string Name { get; private set; }

        public bool IsDeleted { get; private set; } = false;

        public int IdProduct { get; private set; }

        public abstract decimal CalculatePrice();

        public void Delete()
        {
            this.IsDeleted = true;
        }

        protected virtual int GenerateId()
        {
            return idCounter++;
        }
    }
}
