using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.Commands
{
    public static class CommandFactory
    {
        public static ICommand GetCommand(string commandName)
        {
            ICommand command = null;
            switch (commandName.ToLower())
            {
                case "dance":
                case "wave":
                case "jump":
                case "laugh":
                    command = new EmoteCommands();
                    break;
                case "get":
                    command = new GetCmd();
                    break;
                case "help":
                    command = new Help();
                    break;
                default:
                    Console.WriteLine("I don't know what '" + commandName + "' means.");
                    command = new CommandError();
                    break;
            }
            return command;
        }
    }
}
