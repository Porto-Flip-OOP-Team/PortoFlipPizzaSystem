using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Validation;
using ProtoFlipPizzaSystem.Models.Utils;

namespace ProtoFlipPizzaSystem.Models.Administrator.Abstract
{
    public abstract class Product : IProduct
    {
        protected static int idCounter = 1;

        private readonly int id;
        private bool isDeleted;
        private int totalQuantity;
        private string name;

        public Product(string name)
        {
            this.id = this.GenerateId();
            this.Name = name;
            this.isDeleted = false;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.ValidateStringNullEmpty(value, "The string cannot be null or empty!");
                string lengthMessage = string.Format(GlobalConstants.InvalidNameLength, GlobalConstants.MinNameLength, GlobalConstants.MaxNameLength);
                Validator.ValidateIntRange(value.Length, GlobalConstants.MinNameLength, GlobalConstants.MaxNameLength, lengthMessage);
            }
        }

        // public bool IsDeleted { get; private set; } = false;

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public int TotalQuantity
        {
            get
            {
                return this.totalQuantity;
            }

            set
            {
                string message = string.Format(GlobalConstants.InvalidQuantity, nameof(TotalQuantity), GlobalConstants.MinQuantity, GlobalConstants.MaxTotalQuantity);
                Validator.ValidateIntRange(value, GlobalConstants.MinQuantity, GlobalConstants.MaxTotalQuantity, message);
                this.totalQuantity = value;
            }
        }

        public abstract decimal CalculatePrice();

        public void Delete()
        {
            this.isDeleted = true;
        }

        protected virtual int GenerateId()
        {
            return idCounter++;
        }

        public virtual void UpdateTotalQuantity(int newQuantity)
        {
            this.TotalQuantity = newQuantity;
        }
    }
}
