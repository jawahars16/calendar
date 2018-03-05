using System.Collections.Generic;

namespace Calendar.Common.Model
{
    public class CalendarItem
    {
        private long id;
        private string name;
        private int count;
        private string accountName;
        private string accountType;
        private List<Event> events;

        public CalendarItem(long id, string name, int count, string accountName, string accountType)
        {
            this.Id = id;
            this.Name = name;
            this.Count = count;
            this.AccountName = accountName;
            this.AccountType = accountType;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public string AccountType { get => accountType; set => accountType = value; }
        public List<Event> Events { get => events; set => events = value; }
    }
}