using EventSphereManagement.DTOs;

namespace EventSphereManagement.Services.Interfaces
{
    public interface IEventService
    {
        Task<EventDTO> GetEventByIdAsync(int eventId);
        Task<IEnumerable<EventDTO>> GetAllEventsAsync();
        Task<IEnumerable<EventDTO>> GetEventsByOrganizerIdAsync(int organizerId);
        Task<IEnumerable<EventDTO>> GetUpcomingEventsSortedByPopularityAsync();
        Task CreateEventAsync(EventDTO eventDto);
        Task UpdateEventAsync(EventDTO eventDto, int eventId);
        Task DeleteEventAsync(int eventId);
    }
}
