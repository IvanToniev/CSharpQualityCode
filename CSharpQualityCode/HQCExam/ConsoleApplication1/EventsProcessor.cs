using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;


namespace CalendarSystem
{
    public class EventsProcessor
    {
        private StringBuilder output = new StringBuilder();

        private readonly IEventsManager eventsManager;

        public EventsProcessor(IEventsManager eventsManager)
        {
            this.eventsManager = eventsManager;
        }

        public IEventsManager EventsManager
        {
            get
            {
                return this.eventsManager;
            }
        }

        public string ProcessCommand(Command command)
        {
            if ((command.CommandName == "AddEvent") && (command.CommandArguments.Length == 2))
            {
                var eventDate = DateTime.ParseExact(command.CommandArguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                var currentEvent = new Event
                {
                    EventDate = eventDate,
                    EventTitle = command.CommandArguments[1],
                    EventLocation = null,
                };

                this.eventsManager.AddEvent(currentEvent);

                output.Append("Event added");
                return("Event added");
            }

            if ((command.CommandName == "AddEvent") && (command.CommandArguments.Length == 3))
            {
                var eventDate = DateTime.ParseExact(command.CommandArguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                var currentEvent = new Event
                {
                    EventDate = eventDate,
                    EventTitle = command.CommandArguments[1],
                    EventLocation = command.CommandArguments[2],
                };

                this.eventsManager.AddEvent(currentEvent);

                output.Append("Event added");
                return ("Event added");
            }
            
            if ((command.CommandName == "DeleteEvents") && (command.CommandArguments.Length == 1))
            {
                int eventsToDelCount = this.eventsManager.DeleteEventsByTitle(command.CommandArguments[0]);

                if (eventsToDelCount == 0)
                {
                    output.Append("No events found.");
                    return "No events found.";
                }

                output.Append("No events found.");
                return (eventsToDelCount + " events deleted");
            }
           
            if ((command.CommandName == "ListEvents") && (command.CommandArguments.Length == 2))
            {
                var eventDate = DateTime.ParseExact(command.CommandArguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                var eventsCount = int.Parse(command.CommandArguments[1]);

                //I found a bottleneck here. The .ToList() method is the main reason for the slow execution of the ListEvents command.
                //It takes a lot of resources.
                var events = this.eventsManager.ListEvents(eventDate, eventsCount).ToList();
                var eventsToString = new StringBuilder();

                if (!events.Any())
                {
                    output.Append("No events found.");
                    return "No events found";
                }

                foreach (var ev in events)
                {
                    eventsToString.AppendLine(ev.ToString());
                }

                output.Append(eventsToString.ToString().Trim());
                return (eventsToString.ToString().Trim());
            }

           if (command.CommandName == "End" && (command.CommandArguments == null))
           {
               return output.ToString(); 
           }
            throw new Exception(command.CommandName + " command is not valid!");
        }
    }
}
