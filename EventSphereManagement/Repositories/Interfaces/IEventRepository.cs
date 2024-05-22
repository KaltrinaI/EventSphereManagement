using EventSphereManagement.Models;

namespace EventSphereManagement.Repositories.Interfaces
{
    public interface IEventRepository
    {
        Task<Event> GetEventById(int eventId);
        Task<IEnumerable<Event>> GetAllEvents();
        Task<IEnumerable<Event>> GetEventsByOrganizerId(int organizerId);
        Task AddEvent(Event @event);
        Task UpdateEvent(Event @event, int eventId);
        Task DeleteEvent(int eventId);
        Task<IEnumerable<Event>> GetUpcomingEventsSortedByPopularity();
    }
}
