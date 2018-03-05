using System;

namespace Calendar.Common.Model
{
    public class Day
    {
        private DateTime date;

        public Day(DateTime date)
        {
            this.date = date;
        }

        public DateTime Date { get => date; set => date = value; }
    }
}