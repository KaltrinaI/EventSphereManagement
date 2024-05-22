using EventSphereManagement.DTOs;
using EventSphereManagement.Models;

namespace EventSphereManagement.Repositories.Interfaces
{
    public interface IAttendeeRepository
    {
        Task<Attendee> GetAttendeeById(int attendeeId);
        Task<IEnumerable<Attendee>> GetAllAttendees();
        Task AddAttendee(AttendeeDTO attendee);
        Task UpdateAttendee(Attendee attendee,int attendeeId);
        Task DeleteAttendee(int attendeeId);
        Task<IEnumerable<Attendee>> GetAttendeesForEvent(int eventId);
        
    }
}
