using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    public interface ICommand
    {
        void Execute(string command);
    }
}
