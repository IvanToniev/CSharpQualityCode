using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSystem
{
    public interface IEventsManager
    {
        /// <summary>
        ///     Adds an event in a given collection.
        /// </summary>
        /// <param name="a">This is the event you will add.</param>
        void AddEvent(Event a);

        /// <summary>
        ///     Deletes an event from a given collection.
        /// </summary>
        /// <param name="b">This is the title of the event you want to delete.</param>
        /// <returns>The number of deleted events.</returns>
        int DeleteEventsByTitle(string b);

        /// <summary>
        ///     Lists the events in a given collection.
        /// </summary>
        /// <param name="c">This is the date of the events you want to list.</param>
        /// <param name="d">This is the count of the events you want to list.</param>
        /// <returns>The events you want to list stringified.</returns>
        IEnumerable<Event> ListEvents(DateTime c, int d);
    }
}
