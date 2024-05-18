namespace EventSphereManagement.Models
{
    public class Attendee
    {
        public int AttendeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<EventAttendees> EventAttendees { get; set; }
    }
}
