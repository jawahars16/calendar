using System;
using System.Collections.Generic;
using System.Linq;

namespace Calendar.Common.Store
{
    public class TestDataStore
    {
        public static List<DateTime> GetDays()
        {
            int year = 2017;
            int month = 12;
            var days = DateTime.DaysInMonth(year, month);

            return Enumerable.Range(1, days)
                .Select(t => new DateTime(year, month, t))
                .ToList();
        }
    }
}