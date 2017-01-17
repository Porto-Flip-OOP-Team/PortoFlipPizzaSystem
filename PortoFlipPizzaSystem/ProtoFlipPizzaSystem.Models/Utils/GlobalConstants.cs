namespace ProtoFlipPizzaSystem.Models.Utils
{
    public class GlobalConstants
    {
        public const string InvalidQuantity = "The {0} can be between {1} and {2}";
        public const string InvalidPrice = "The price can be between {0} and {1}";
        public const string InvalidNameLength = "The name can be between {0} and {1} symbols long.";

        public const int MinQuantity = 0;
        public const int MaxTotalQuantity = 1000;

        public const int MinNameLength = 2;
        public const int MaxNameLength = 30;

        public const decimal MinPrice = 0m;
        public const decimal MaxPrice = 1000m;
    }
}
