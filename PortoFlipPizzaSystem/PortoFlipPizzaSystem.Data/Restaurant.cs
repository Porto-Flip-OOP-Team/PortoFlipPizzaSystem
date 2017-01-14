using System;
using System.Collections.Generic;

using PortoFlipPizzaSystem.Data.Contracts;
using ProtoFlipPizzaSystem.Models.Client.Contracts;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Validation;

namespace PortoFlipPizzaSystem.Data
{
    public class Restaurant : IRestaurant
    {
        private const string CannotAddNullObject = "Cannot add a null object as a {0}.";
        private const string IdCannotBeNegativeNumber = "Id cannot be a negative number.";
        private const string TheGivenIdIsNotPresentInDictionary = "The given id is not present in the dictionary.";


        private static Restaurant restaurantInstance = null;
        private static readonly Lazy<Restaurant> Lazy = new Lazy<Restaurant>(() => new Restaurant());

        private IDictionary<int, ICustomer> customers;
        private IDictionary<int, IIngredient> ingredients;
        private IDictionary<int, IOrder> orders;
        private IDictionary<int, IProduct> products;
        private IDictionary<int, IStaff> staff;

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

        public void AddCustomer(int customerId, ICustomer customer)
        {
            Validator.ValidateIntRange(customerId, 0, int.MaxValue, IdCannotBeNegativeNumber);
            Validator.ValidateNull(customer, string.Format(CannotAddNullObject, nameof(customer)));

            this.customers.Add(customerId, customer);
        }

        public void AddIngredient(int ingredientId, IIngredient ingredient)
        {
            Validator.ValidateIntRange(ingredientId, 0, int.MaxValue, IdCannotBeNegativeNumber);
            Validator.ValidateNull(ingredient, string.Format(CannotAddNullObject, nameof(ingredient)));

            this.ingredients.Add(ingredientId, ingredient);
        }

        public void AddOrder(int orderId, IOrder order)
        {
            Validator.ValidateIntRange(orderId, 0, int.MaxValue, IdCannotBeNegativeNumber);
            Validator.ValidateNull(order, string.Format(CannotAddNullObject, nameof(order)));

            this.orders.Add(orderId, order);
        }

        // May be change the data structure => to have key for a product group and dictionary of products
        public void AddProduct(int productId, IProduct product)
        {
            Validator.ValidateIntRange(productId, 0, int.MaxValue, IdCannotBeNegativeNumber);
            Validator.ValidateNull(product, string.Format(CannotAddNullObject, nameof(product)));

            this.products.Add(productId, product);
        }

        public void AddStaff(int staffId, IStaff staff)
        {
            Validator.ValidateIntRange(staffId, 0, int.MaxValue, IdCannotBeNegativeNumber);
            Validator.ValidateNull(staffId, string.Format(CannotAddNullObject, nameof(staff)));
        }

        public ICollection<ICustomer> GetAllCustomers()
        {
            ICollection<ICustomer> customersList = new List<ICustomer>();
            foreach (var customer in this.customers)
            {
                customersList.Add(customer.Value);
            }

            return customersList;
        }

        public ICollection<IIngredient> GetAllIngredients()
        {
            ICollection<IIngredient> ingredientsList = new List<IIngredient>();
            foreach (var ingredient in this.ingredients)
            {
                ingredientsList.Add(ingredient.Value);
            }

            return ingredientsList;
        }

        public ICollection<IOrder> GetAllOrders()
        {
            ICollection<IOrder> orderList = new List<IOrder>();
            foreach (var order in this.orders)
            {
                orderList.Add(order.Value);
            }

            return orderList;
        }

        public ICollection<IProduct> GetAllProducts()
        {
            ICollection<IProduct> productsList = new List<IProduct>();
            foreach (var product in this.products)
            {
                productsList.Add(product.Value);
            }

            return productsList;
        }

        public ICollection<IStaff> GetAllStaff()
        {
            ICollection<IStaff> staffList = new List<IStaff>();
            foreach (var person in this.staff)
            {
                staffList.Add(person.Value);
            }

            return staffList;
        }

        public ICustomer GetCustomer(int customerId)
        {
            if (!this.customers.ContainsKey(customerId))
            {
                throw new ArgumentException(TheGivenIdIsNotPresentInDictionary);
            }

            return this.customers[customerId];
        }

        public IIngredient GetIngredient(int ingredientId)
        {
            if (!this.customers.ContainsKey(ingredientId))
            {
                throw new ArgumentException(TheGivenIdIsNotPresentInDictionary);
            }

            return this.ingredients[ingredientId];
        }

        public IOrder GetOrder(int orderId)
        {
            if (!this.customers.ContainsKey(orderId))
            {
                throw new ArgumentException(TheGivenIdIsNotPresentInDictionary);
            }

            return this.orders[orderId];
        }

        public IProduct GetProduct(int productId)
        {
            if (!this.customers.ContainsKey(productId))
            {
                throw new ArgumentException(TheGivenIdIsNotPresentInDictionary);
            }

            return this.products[productId];
        }

        public IStaff GetStuff(int staffId)
        {
            if (!this.customers.ContainsKey(staffId))
            {
                throw new ArgumentException(TheGivenIdIsNotPresentInDictionary);
            }

            return this.staff[staffId];
        }

        public void RemoveCustomer(int customerId)
        {
            if (!this.customers.ContainsKey(customerId))
            {
                throw new ArgumentException(TheGivenIdIsNotPresentInDictionary);
            }

            this.customers[customerId].Delete();
        }

        public void RemoveIngredient(int ingredientId)
        {
            if (!this.customers.ContainsKey(ingredientId))
            {
                throw new ArgumentException(TheGivenIdIsNotPresentInDictionary);
            }

            this.ingredients[ingredientId].Delete();
        }

        public void RemoveOrder(int orderId)
        {
            if (!this.customers.ContainsKey(orderId))
            {
                throw new ArgumentException(TheGivenIdIsNotPresentInDictionary);
            }

            this.orders[orderId].Delete();
        }

        public void RemoveProduct(int productId)
        {
            if (!this.customers.ContainsKey(productId))
            {
                throw new ArgumentException(TheGivenIdIsNotPresentInDictionary);
            }

            this.products[productId].Delete();
        }

        public void RemoveStaff(int staffId)
        {
            if (!this.customers.ContainsKey(staffId))
            {
                throw new ArgumentException(TheGivenIdIsNotPresentInDictionary);
            }

            this.staff[staffId].Delete();
        }

        public void UpdateCustomer(int customerId)
        {
            // TODO  => how
            throw new NotImplementedException();
        }

        public void UpdateOrder(int orderId, IProduct product, int quantity)
        {
            // To ask Krasi
            // this.orders[orderId].pr
        }

        public void UpdateProduct(int productId)
        {
            // Is it nessesary?
            throw new NotImplementedException();
        }

        public void UpdateIngredient(int ingredientID, decimal quantity)
        {
            // To think about
            // this.ingredients[ingredientID].Quantity += quantity;
        }

        public void UpdateStuff(int stuffId)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(int orderId, IProduct product)
        {
            throw new NotImplementedException();
        }

        public void UpdateQuantity(int ingredientID, decimal quantity)
        {
            throw new NotImplementedException();
        }
    }
}