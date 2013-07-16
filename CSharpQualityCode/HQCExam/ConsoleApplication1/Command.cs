using System;
using System.Linq;

namespace CalendarSystem
{
    public struct Command
    {
        public string CommandName { get; set; }
        public string[] CommandArguments { get; set; }

        public static Command Parse(string commandToParse)
        {
            if (commandToParse == "End")
            {
                return new Command { CommandName = "End", CommandArguments = null };
            }
            int commandToParseIndex = commandToParse.IndexOf(' ');
            if (commandToParseIndex == -1)
            {
                throw new ArgumentException("Invalid command: " + commandToParse);
            }

            string commandName = commandToParse.Substring(0, commandToParseIndex);
            string argument = commandToParse.Substring(commandToParseIndex + 1);

            var commandArguments = argument.Split('|');
            for (int i = 0; i < commandArguments.Length; i++)
            {
                argument = commandArguments[i];
                commandArguments[i] = argument.Trim();
            }

            var command = new Command { CommandName = commandName, CommandArguments = commandArguments };

            return command;
        }
    }
}
