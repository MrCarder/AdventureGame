using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.Commands
{
    class CommandDictionary : ICommand
    {
        public CommandDictionary(string commandPass)
        {
            Dictionary<string, string> CmdDictionary = new Dictionary<string, string>();
            CmdDictionary.Add("dance", "You do a jig");
            CmdDictionary.Add("", "You have to type something, I can't read your mind...");
            CmdDictionary.Add("jump", "You jump and land on a broken board. You fall 50 feet through the floor. You loose.");
            CmdDictionary.Add("laugh", "What is so funny?");
            CmdDictionary.Add("wave", "Wave at who?");

            string dictionaryResponse = CmdDictionary[commandPass];
            Console.WriteLine(dictionaryResponse);
        }

        public void Execute()
        {
            
        }
    }
}
