using System;
using System.Collections.Generic;

using PortoFlipPizzaSystem.Data.Contracts;
using ProtoFlipPizzaSystem.Models.Client.Contracts;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace PortoFlipPizzaSystem.Data
{
    public class Restaurant : IRestaurant
    {
        private static Restaurant restaurantInstance = null;
        private static readonly Lazy<Restaurant> Lazy = new Lazy<Restaurant>(() => new Restaurant());

        private Dictionary<int, ICustomer> customers;
        private Dictionary<int, IIngredient> ingredients;
        private Dictionary<int, IOrder> orders;
        private Dictionary<int, IProduct> products;
        private Dictionary<int, IStaff> staff;

        private Restaurant()
        {
            this.customers = new Dictionary<int, ICustomer>();
            this.ingredients = new Dictionary<int, IIngredient>();
            this.orders = new Dictionary<int, IOrder>();
            this.products = new Dictionary<int, IProduct>();
            this.staff = new Dictionary<int, IStaff>();
        }

        public static Restaurant RestaurantInstance
        {
            get
            {
                return Lazy.Value;
            }
        }

        public void AddCustomer(int Customer, ICustomer customer)
        {
            throw new NotImplementedException();
        }

        public void AddIngredient(int ingredientId, IIngredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void AddOrder(int orderId, IOrder order)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(int id, IProduct product)
        {
            throw new NotImplementedException();
        }

        public void AddStaff(int staffId, IStaff staff)
        {
            throw new NotImplementedException();
        }

        public ICollection<ICustomer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public ICollection<IIngredient> GetAllIngredients()
        {
            throw new NotImplementedException();
        }

        public ICollection<IOrder> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public ICollection<IProduct> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public ICollection<IStaff> GetAllStaff()
        {
            throw new NotImplementedException();
        }

        public ICustomer GetCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public IIngredient GetIngredient(int ingredientId)
        {
            throw new NotImplementedException();
        }

        public IOrder GetOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public IProduct GetProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public IStaff GetStuff(int stuffID)
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public void RemoveIngredient(int ingredientId)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public void RemoveStaff(int staffId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(int orderId, IProduct product)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void UpdateQuantity(int ingredientID, decimal quantity)
        {
            throw new NotImplementedException();
        }

        public void UpdateStuff(int stuffId)
        {
            throw new NotImplementedException();
        }
    }
}