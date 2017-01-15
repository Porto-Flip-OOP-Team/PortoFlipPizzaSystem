namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IRestaurant :
        IAddOrder,
        IGetOrder,
        IRemoveOrder,
        IGetAllOrders,
        IAddIngredient,
        IGetIngredient,
        IRemoveIngredient,
        IGetAllIngredients,
        IAddProduct,
        IGetProduct,
        IRemoveProduct,
        IGetAllProducts,
        IAddCustomer,
        IGetCustomer,
        IRemoveCustomer,
        IGetAllCustomer,
        IAddStaff,
        IGetStaff,
        IRemoveStaff,
        IGetAllStaff
    {
    }
}