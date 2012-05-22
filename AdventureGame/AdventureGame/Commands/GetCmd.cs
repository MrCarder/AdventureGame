using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.Commands
{
    class GetCmd : ICommand
    {
        public void Execute()
        {
                Console.WriteLine("Get what?");
        }
    }
}
