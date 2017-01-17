using ProtoFlipPizzaSystem.Models.Contracts;
using ProtoFlipPizzaSystem.Models.Utils;

namespace ProtoFlipPizzaSystem.Models.Common
{
    public class IdentifiableObject : IIdentifiable
    {
        private readonly int id;

        public IdentifiableObject()
        {
            this.id = DataGenerator.GenerateId();
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }
    }
}
