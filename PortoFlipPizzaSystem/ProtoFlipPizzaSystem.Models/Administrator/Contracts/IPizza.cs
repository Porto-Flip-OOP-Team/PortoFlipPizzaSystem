using System.Collections.Generic;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    interface IPizza : IFood
    {
        void SetPizzaPremium(decimal pizzaPremium);
        void SetCoeff(decimal coeff);
    }
}
