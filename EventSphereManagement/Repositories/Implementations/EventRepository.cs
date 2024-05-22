using EventSphereManagement.Data;
using EventSphereManagement.Models;
using EventSphereManagement.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventSphereManagement.Repositories.Implementations
{
    public class EventRepository : IEventRepository
    {
        private readonly AppDbContext _context;

        public EventRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Event> GetEventById(int eventId)
        {
            return await _context.Events.FindAsync(eventId);
        }

        public async Task<IEnumerable<Event>> GetAllEvents()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<IEnumerable<Event>> GetEventsByOrganizerId(int organizerId)
        {
            return await _context.Events.Where(e => e.OrganizerId == organizerId).ToListAsync();
        }

        public async Task AddEvent(Event @event)
        {
            _context.Events.Add(@event);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEvent(Event @event, int eventId)
        {
            var existingEvent = await _context.Events.FindAsync(eventId);
            if (existingEvent != null)
            {
                existingEvent.Name = @event.Name;
                existingEvent.Description = @event.Description;
                existingEvent.StartDate = @event.StartDate;
                existingEvent.EndDate = @event.EndDate;
                existingEvent.Location = @event.Location;
                existingEvent.Capacity = @event.Capacity;
                existingEvent.OrganizerId = @event.OrganizerId;
                _context.Events.Update(existingEvent);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteEvent(int eventId)
        {
            var @event = await _context.Events.FindAsync(eventId);
            if (@event != null)
            {
                _context.Events.Remove(@event);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Event>> GetUpcomingEventsSortedByPopularity()
        {
            var currentDate = DateTime.Now;
            return await _context.Events
                .Include(e => e.Organizer)
                .Include(e => e.Tickets)
                .Include(e => e.EventAttendees)
                .Where(e => e.StartDate > currentDate)
                .OrderByDescending(e => e.Tickets.Count) // Assuming popularity is measured by the number of tickets
                .ToListAsync();
        }
    }
}
