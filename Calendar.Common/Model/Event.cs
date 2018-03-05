using System;

namespace Calendar.Common.Model
{
    public class Event
    {
        /// <summary>
        /// Calendar event name/title/subject
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Event start time
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// Event end time
        /// </summary>
        public DateTime End { get; set; }

        /// <summary>
        /// Gets or sets the location of the event
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Whether or not this is an "all-day" event.
        /// </summary>
        /// <remarks>All-day events end at midnight of the following day</remarks>
        public bool AllDay { get; set; }

        /// <summary>
        /// Optional event description/details
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Platform-specific unique calendar event identifier
        /// </summary>
        /// <remarks>This ID will be the same for each instance of a recurring event.</remarks>
        public string ExternalID { get; set; }

        public string Color { get; set; }

        public string Status { get; set; }

        /// <summary>
        /// Simple ToString helper, to assist with debugging.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Name=" + Name + ", AllDay=" + AllDay + ", Start=" + Start + ", End=" + End + ", Location=" + Location;
        }
    }
}