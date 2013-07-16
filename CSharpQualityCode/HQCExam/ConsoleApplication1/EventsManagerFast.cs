using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;
using EventMultyDict = Wintellect.PowerCollections.MultiDictionary<string, CalendarSystem.Event>;

namespace CalendarSystem
{
    public class EventsManagerFast : IEventsManager
    {
        private readonly EventMultyDict eventsByTitles = new EventMultyDict(true);
        private readonly OrderedMultiDictionary<DateTime, Event> eventsByDates = new OrderedMultiDictionary<DateTime, Event>(true);

        public OrderedMultiDictionary<DateTime, Event> EventsByDates
        {
            get
            {
                return this.eventsByDates;
            }
        }

        public EventMultyDict EventsByTitles
        {
            get
            {
                return this.eventsByTitles;
            }
        }

        public void AddEvent(Event eventToAdd)
        {
            string eventTitleLowerCase = eventToAdd.EventTitle.ToLowerInvariant();
            this.eventsByTitles.Add(eventTitleLowerCase, eventToAdd);
            this.eventsByDates.Add(eventToAdd.EventDate, eventToAdd);
        }

        public int DeleteEventsByTitle(string eventTitle)
        {
            string titleToLower = eventTitle.ToLowerInvariant();
            var eventToDel = this.eventsByTitles[titleToLower];
            int eventsToDelCount = eventToDel.Count;

            foreach (var currentEvent in eventToDel)
            {
                this.eventsByDates.Remove(currentEvent.EventDate, currentEvent);
            }

            this.eventsByTitles.Remove(titleToLower);

            return eventsToDelCount;
        }

        public IEnumerable<Event> ListEvents(DateTime date, int eventsCount)
        {
            var eventsCol =
                from currentEvent in this.eventsByDates.RangeFrom(date, true).Values
                select currentEvent;
            var events = eventsCol.Take(eventsCount);
            return events;
        }
    }
}
