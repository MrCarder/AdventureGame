using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.Commands
{
    class Wave : ICommand 
    {
        public void Execute()
        {
            Console.WriteLine("Wave at who?");
        }
    }
}
