using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureGame.Commands;

namespace AdventureGame
{
    class GameRunner
    {
        public void Run()
        {
            string input;
            Console.WriteLine("Welcome to Adventure Game");
            do
            {
                Console.Write("$ ");
                input = Console.ReadLine();
                Console.WriteLine();

                ICommand command = CommandFactory.GetCommand(input);
                command.Execute();
            }
            while (input.ToLower() != "exit");
        }
    }
}
