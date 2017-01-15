using PortoFlipPizzaSystem.Core.Contracts;
using System;
using System.Linq;

namespace PortoFlipPizzaSystem.Core
{
    public class App : IApp
    {
        private ICommandHandler commandHandler;

        public App(ICommandHandler commandHandler)
        {
            this.CommandHandler = commandHandler;
        }

        public App()
            : this(new CommandHandler())
        {
        }

        public ICommandHandler CommandHandler
        {
            get { return this.commandHandler; }
            private set { this.commandHandler = value; }
        }

        public void RunProgram()
        {
            while (true)
            {
                string commandLine = ReadCommand();

                if (string.IsNullOrEmpty(commandLine))
                {
                    break;
                }

                string[] tokens = ParseCommand(commandLine);

                string command = tokens[0];
                string[] parameters = tokens.Skip(1).ToArray();

                try
                {
                    string commandResult = this.CommandHandler.ExecuteCommand(command, parameters);
                    Console.WriteLine(commandResult);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private string ReadCommand()
        {
            return Console.ReadLine();
        }

        private string[] ParseCommand(string command)
        {
            string[] commandParameters = command.Split(
                new string[] { " " }, 
                StringSplitOptions.RemoveEmptyEntries);

            return commandParameters;
        }
    }
}
