using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.Commands
{
    class Dance : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("You do a jig");
        }
    }
}
