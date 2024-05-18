namespace EventSphereManagement.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<EventAttendees> EventAttendees { get; set; }
    }
}
