using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Common;
using ProtoFlipPizzaSystem.Models.Utils;
using ProtoFlipPizzaSystem.Models.Validation;

namespace ProtoFlipPizzaSystem.Models.Administrator.Abstract
{
    public abstract class Product : IdentifiableObject, IProduct
    {
        private bool isDeleted;
        private int totalQuantity;
        private string name;

        public Product(string name)
        {
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

                this.name = value;
            }
        }

         public bool IsDeleted { get; set; }

        public int TotalQuantity
        {
            get
            {
                return this.totalQuantity;
            }

            set
            {
                string message = string.Format(GlobalConstants.InvalidQuantity, nameof(this.TotalQuantity), GlobalConstants.MinQuantity, GlobalConstants.MaxTotalQuantity);
                Validator.ValidateIntRange(value, GlobalConstants.MinQuantity, GlobalConstants.MaxTotalQuantity, message);
                this.totalQuantity = value;
            }
        }

        public abstract decimal CalculatePrice();

        public virtual void UpdateTotalQuantity(int newQuantity)
        {
            this.TotalQuantity = newQuantity;
        }
    }
}
