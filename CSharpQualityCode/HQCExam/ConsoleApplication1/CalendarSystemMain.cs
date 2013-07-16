using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarSystem
{
    class CalendarSystemMain
    {
        internal static void Main()
        {
            var eventsManager = new EventsManager();
            var processor = new EventsProcessor(eventsManager);
            List<string> commands = new List<string>();

            while (true)
            {
                string commandEntered = Console.ReadLine();

                if (commandEntered == "End" || commandEntered == null)
                {
                    foreach (var command in commands)
                    {
                        try
                        {
                            Console.WriteLine(processor.ProcessCommand(Command.Parse(command)));
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
                    }
                    break;
                }
        
                 commands.Add(commandEntered);
            }
        }
    }
}





