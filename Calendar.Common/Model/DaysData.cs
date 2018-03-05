using System;
using System.Collections.Generic;
using System.Linq;

namespace Calendar.Common.Model
{
    public class DaysData
    {
        public List<DateTime> Dates { get; set; }

        public List<Event> Events { get; set; }

        public List<Event> GetEvents(DateTime date)
        {
            return Events.Where(e =>
            e.Start.Date == date ||
            (e.End.Date == date && !e.AllDay) ||
            (e.Start.Date < date && e.End.Date > date)
            ).ToList();
        }
    }
}