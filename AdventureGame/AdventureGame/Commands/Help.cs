using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.Commands
{
    class Help : ICommand
    {
        public void Execute(string command)
        {
            Console.WriteLine("Command List\n============\ndance\nget\njump\nlaugh\nwave\nexit\n");
        }
    }
}
