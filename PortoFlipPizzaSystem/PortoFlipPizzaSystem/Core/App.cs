namespace PortoFlipPizzaSystem.Core
{
    using Contracts;
    using System;
    using System.Linq;

    public class App
    {
        public App(ICommandHandler commandHandler)
        {
            this.CommandHandler = commandHandler;
        }

        public App()
            : this(new CommandHandler())
        {
        }

        public ICommandHandler CommandHandler { get; private set; }

        public void RunProgram()
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (string.IsNullOrEmpty(line))
                {
                    break;
                }

                // Received line is going to be splitted into an array which will contain command and parameters
                var tokens = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                var command = tokens[0];
                var parameters = tokens.Skip(1).ToArray();

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
    }
}
