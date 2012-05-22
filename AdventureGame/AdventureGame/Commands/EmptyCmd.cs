using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.Commands
{
    class EmptyCmd : ICommand
    {
        public void Execute(string command)
        {
            Console.WriteLine("You have to type something, I can't read your mind...");
        }
    }
}
