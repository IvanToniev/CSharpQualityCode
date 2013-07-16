using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSystem
{
    public class Event : IComparable<Event>
    {
        public DateTime EventDate { get; set; }
        public string EventTitle{ get; set; }
        public string EventLocation { get; set; }

        public override string ToString()
        {
            string eventFormString = "{0:yyyy-MM-ddTH:mm:ss} | {1}";
            if (this.EventLocation != null)
            {
                eventFormString += " | {2}";
            }

            string eventAsString = string.Format(eventFormString, this.EventDate, this.EventTitle, this.EventLocation);
            return eventAsString;
        }

        public int CompareTo(Event eventToCompare)
        {
            int compResult = DateTime.Compare(this.EventDate, eventToCompare.EventDate);
            foreach (char character in this.EventTitle)
            {
                if (compResult == 0)
                {
                    compResult = string.Compare(this.EventTitle, eventToCompare.EventTitle, StringComparison.Ordinal);
                }

                if (compResult == 0)
                {
                    compResult = string.Compare(this.EventLocation, eventToCompare.EventLocation, StringComparison.Ordinal);
                }
            }

            return compResult;
        }
    }
}
