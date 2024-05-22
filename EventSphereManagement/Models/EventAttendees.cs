using System.ComponentModel.DataAnnotations;

namespace EventSphereManagement.Models
{
    public class EventAttendees
    {
        [Key]
        public int EventId { get; set; }
        public int AttendeeId { get; set; }
        public Event Event { get; set; }
        public Attendee Attendee { get; set; }
    }
}
