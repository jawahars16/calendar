using System;

namespace Calendar.Common
{
    public static class Extensions
    {
        private static readonly DateTime Jan1st1970 = new DateTime
    (1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static long TimeMillis(this DateTime date)
        {
            return (long)(date - Jan1st1970).TotalMilliseconds;
        }

        public static DateTime MillisTime(this Int64 millis)
        {
            TimeSpan time = TimeSpan.FromMilliseconds(millis);
            return Jan1st1970 + time;
        }

        public static string ToReadableString(this TimeSpan t)
        {
            if (t.TotalSeconds <= 1)
            {
                return $@"{t:s\.ff} seconds";
            }
            if (t.TotalMinutes <= 1)
            {
                return $@"{t:%s} seconds";
            }
            if (t.TotalHours <= 1)
            {
                return $@"{t:%m} minutes";
            }
            if (t.TotalDays <= 1)
            {
                return $@"{t:%h} hours";
            }

            return $@"{t:%d} days";
        }
    }
}