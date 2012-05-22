using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.Commands
{
    class Laugh : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("What is so funny?");
        }
    }
}
