using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.Commands
{
    class Jump : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("You jump and land on a broken board. You fall 50 feet through the floor. You loose.");
        }
    }
}
