using PortoFlipPizzaSystem.Core.Contracts;
using System;

namespace PortoFlipPizzaSystem.Core
{
    public class CommandHandler : ICommandHandler
    {
        private IController controller;

        public CommandHandler(IController controller)
        {
            this.Controller = controller;
        }

        public IController Controller
        {
            get { return this.controller; }
            private set { this.controller = value; }
        }

        public string ExecuteCommand(string name, string[] parameters)
        {
            switch (name)
            {
                case "Name of the object":
                    return "";

                case "Name of the object1":
                    return "";
                case "Name of the object2":
                    return "";

                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
