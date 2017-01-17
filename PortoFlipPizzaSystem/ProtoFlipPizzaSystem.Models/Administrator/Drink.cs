using System.Text;

using ProtoFlipPizzaSystem.Models.Administrator.Abstract;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Contracts;
using ProtoFlipPizzaSystem.Models.Enums;
using ProtoFlipPizzaSystem.Models.Utils;
using ProtoFlipPizzaSystem.Models.Validation;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class Drink : Product, IProduct, IDrink, ICalculatable, IDeletable, INamable
    {
        private const int MaxUnitQuantity = 1500;
        private readonly MeasureUnitType measureUnitType;
        private decimal price;
        private int totalQuantity;
        private int unitQuantity;

        public Drink(string name, decimal price, int unitQuantity, int totalQuantity, MeasureUnitType measureUnitType)
            : base(name)
        {
            this.Price = price;
            this.TotalQuantity = totalQuantity;
            this.measureUnitType = measureUnitType;
            this.UnitQuantity = unitQuantity;
        }

        public MeasureUnitType MeasureUnitType
        {
            get
            {
                return this.measureUnitType;
            }
        }

        public int UnitQuantity
        {
            get
            {
                return this.unitQuantity;
            }

            private set
            {
                string message = string.Format(GlobalConstants.InvalidQuantity, nameof(this.UnitQuantity), GlobalConstants.MinQuantity, MaxUnitQuantity);
                Validator.ValidateDecimalRange(value, GlobalConstants.MinQuantity, MaxUnitQuantity, message);
                this.unitQuantity = value;
            }
        }

        private decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                Validator.ValidateDecimalRange(value, GlobalConstants.MinPrice, GlobalConstants.MaxPrice, GlobalConstants.InvalidQuantity);

                this.price = value;
            }
        }

        public override decimal CalculatePrice()
        {
            return this.Price;
        }

        public override string ToString()
        {
            StringBuilder visualization = new StringBuilder();
            visualization.Append($"{this.Name} {this.UnitQuantity} {this.MeasureUnitType} {this.Price}");
            return visualization.ToString();
        }
    }
}
