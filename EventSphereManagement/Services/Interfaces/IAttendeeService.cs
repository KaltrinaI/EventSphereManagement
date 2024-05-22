using EventSphereManagement.DTOs;

namespace EventSphereManagement.Services.Interfaces
{
    public interface IAttendeeService
    {
        Task<AttendeeDTO> GetAttendeeById(int attendeeId);
        Task<IEnumerable<AttendeeDTO>> GetAllAttendees();
        Task RegisterAttendee(AttendeeDTO attendeeDto);
        Task UpdateAttendee(AttendeeDTO attendeeDto, int attendeeId);
        Task RemoveAttendee(int attendeeId);
        Task<IEnumerable<AttendeeDTO>> GetAttendeesByEvent(int eventId);
        Task CheckInAttendee(int eventId, int attendeeId);
    }
}
