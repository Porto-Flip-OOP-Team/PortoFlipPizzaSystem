using System;
using System.Linq;

using PortoFlipPizzaSystem.Core.Contracts;
using PortoFlipPizzaSystem.Data;
using PortoFlipPizzaSystem.Data.Contracts;
using ProtoFlipPizzaSystem.Models.Administrator;
using ProtoFlipPizzaSystem.Models.Enums;

namespace PortoFlipPizzaSystem.Core
{
    public class App : IApp
    {
        private IRestaurant restaurant;

        public App()
        {
            this.RestaurantInstance = Restaurant.RestaurantInstance;
        }

        public IRestaurant RestaurantInstance
        {
            get { return this.restaurant; }
            private set { this.restaurant = value; }
        }

        public void RunProgram()
        {
            while (true)
            {
                try
                {
                    string commandLine = this.ReadCommand();

                    if (string.IsNullOrEmpty(commandLine))
                    {
                        throw new ArgumentOutOfRangeException("Command line cannot be empty!");
                    }

                    string[] tokens = this.ParseCommand(commandLine);

                    string command = tokens[0];
                    string[] parameters = tokens.Skip(1).ToArray();

                    string commandResult = this.ExecuteCommand(command, parameters);

                    Console.WriteLine(commandResult);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string ReadCommand()
        {
            return Console.ReadLine();
        }

        public string[] ParseCommand(string command)
        {
            string[] commandParameters = command.Split(
                new string[] { " " },
                StringSplitOptions.RemoveEmptyEntries);

            return commandParameters;
        }

        public string ExecuteCommand(string command, string[] parameters)
        {
            switch (command)
            {
                case "CreateDrink":
                    var drinkName = parameters[0];
                    var drinkPrice = decimal.Parse(parameters[1]);
                    var drinkUnitQuantity = int.Parse(parameters[2]);
                    var drinkTotalQuantity = int.Parse(parameters[3]);

                    MeasureUnitType parsedDrinkMeasureUnit;
                    Enum.TryParse<MeasureUnitType>(parameters[4], out parsedDrinkMeasureUnit);

                    var drink = new Drink(drinkName, drinkPrice, drinkUnitQuantity, drinkTotalQuantity, parsedDrinkMeasureUnit);

                    this.RestaurantInstance.AddProduct(drink.Id, drink);

                    var successfulDrinkResult = $"Drink with name {drink.Name} and Id {drink.Id} was successfully created!";

                    return successfulDrinkResult;

                case "CreateIngredient":
                    var ingredientName = parameters[0];
                    var ingredientPrice = decimal.Parse(parameters[1]);
                    var ingredientUnitQuantity = int.Parse(parameters[2]);

                    MeasureUnitType parsedIngredientMeasureUnit;
                    Enum.TryParse<MeasureUnitType>(parameters[3], out parsedIngredientMeasureUnit);

                    var ingredient = new Ingredient(ingredientName, ingredientPrice, ingredientUnitQuantity, parsedIngredientMeasureUnit);

                    this.RestaurantInstance.AddIngredient(ingredient.Id, ingredient);

                    var successfulIngredientResult = $"Ingredient {ingredient.Name} with Id {ingredient.Id} was successfully created!";

                    return successfulIngredientResult;

                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
