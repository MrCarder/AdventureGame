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
            //CommandDictionary commandPass = new CommandDictionary(commandName);



            switch (commandName.ToLower())
            {
                case "dance":
                    command = new CommandDictionary(commandName);
                    break;
                case "wave":
                    command = new CommandDictionary(commandName);
                    break;
                case "jump":
                    command = new CommandDictionary(commandName);
                    break;
                case "laugh":
                    command = new CommandDictionary(commandName);
                    break;
                //case "get":
                //    command = new GetCmd();
                //    break;
                //case "help":
                //    command = new Help();
                //    break;
                case "":
                    command = new CommandDictionary(commandName);
                    break;
                case "exit":
                    command = new Exit();
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
