using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSystem
{
    public class EventsManager : IEventsManager
    {
        private List<Event> eventsList = new List<Event>();

        public List<Event> EventsList
        {
            get
            {
                return this.eventsList;
            }
            set
            {
                this.eventsList = value;
            }
        }

        public void AddEvent(Event currentEvent)
        {
            this.eventsList.Add(currentEvent);
        }

        public int DeleteEventsByTitle(string eventTitle)
        {
            return this.eventsList.RemoveAll(events => events.EventTitle.ToLowerInvariant() == eventTitle.ToLowerInvariant());
        }

        public IEnumerable<Event> ListEvents(DateTime date, int eventsCount)
        {
            return (from currentEvent in this.eventsList
                    where currentEvent.EventDate >= date
                    orderby currentEvent.EventDate, currentEvent.EventTitle, currentEvent.EventLocation
                    select currentEvent).Take(eventsCount);

        }
    }
}
