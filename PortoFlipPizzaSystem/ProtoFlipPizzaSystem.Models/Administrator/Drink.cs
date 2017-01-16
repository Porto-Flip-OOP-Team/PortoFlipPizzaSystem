using System.Text;

using ProtoFlipPizzaSystem.Models.Administrator.Abstract;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Enums;
using ProtoFlipPizzaSystem.Models.Contracts;
using ProtoFlipPizzaSystem.Models.Validation;
using ProtoFlipPizzaSystem.Models.Utils;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class Drink : Product, IProduct, IDrink, ICalculatable, IDeletable, IIdentifiable, INamable
    {

        private const int MaxUnitQuantity = 1500;

        private decimal price;
        private int totalQuantity;
        private int unitQuantity;
        private readonly MeasureUnitType measureUnitType;


        public Drink(string name, decimal price, int unitQuantity, int totalQuantity, MeasureUnitType measureUnitType)
            : base(name)
        {
            this.Price = price;
            this.TotalQuantity = totalQuantity;
            this.measureUnitType = measureUnitType;
            this.UnitQuantity = unitQuantity;
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
            }
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
                string message = string.Format(GlobalConstants.InvalidQuantity, nameof(UnitQuantity), GlobalConstants.MinQuantity, MaxUnitQuantity);
                Validator.ValidateDecimalRange(value, GlobalConstants.MinQuantity, MaxUnitQuantity, message);
                this.unitQuantity = value;
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
