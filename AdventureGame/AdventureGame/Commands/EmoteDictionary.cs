using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.Commands
{
    class EmoteCommands : ICommand
    {
        private Dictionary<string, string> EmoteDictionary = new Dictionary<string, string>();

        public EmoteCommands()
        {
            EmoteDictionary.Add("dance", "You do a jig");
            EmoteDictionary.Add("jump", "You jump and land on a broken board. You fall 50 feet through the floor. You loose.");
            EmoteDictionary.Add("laugh", "What is so funny?");
            EmoteDictionary.Add("wave", "Wave at who?");
        }

        public void Execute(string commandPass)
        {
            string eDictionaryResponse = EmoteDictionary[commandPass];
            Console.WriteLine(eDictionaryResponse);
        }
    }
}
