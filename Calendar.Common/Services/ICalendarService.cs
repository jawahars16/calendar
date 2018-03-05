using Calendar.Common.Model;
using System.Collections.Generic;

namespace Calendar.Common.Services
{
    public interface ICalendarService
    {
        List<CalendarItem> GetAllCalendars();
    }
}