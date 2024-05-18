namespace EventSphereManagement.Models
{
    public class EventAttendees
    {
        public int EventId { get; set; }
        public int AttendeeId { get; set; }
        public Event Event { get; set; }
        public Attendee Attendee { get; set; }
    }
}
