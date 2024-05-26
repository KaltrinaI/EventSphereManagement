using System.ComponentModel.DataAnnotations;

namespace EventSphereManagement.Models
{
    public class Attendee
    {
        [Key]
        public int AttendeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // this property
        public int EventId { get; set; }

        // this navigation property
        public Event Event { get; set; }
    }
}
