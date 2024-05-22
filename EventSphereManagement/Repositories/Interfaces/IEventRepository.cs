﻿using EventSphereManagement.DTOs;
using EventSphereManagement.Models;

namespace EventSphereManagement.Repositories.Interfaces
{
    public interface IEventRepository
    {
        Task<Event> GetEventById(int eventId);
        Task<IEnumerable<Event>> GetAllEvents();
        Task<IEnumerable<Event>> GetEventsByOrganizerId(int organizerId);
        Task AddEvent(EventRequestDTO @event);
        Task UpdateEvent(EventRequestDTO @event, int eventId);
        Task DeleteEvent(int eventId);
        Task<IEnumerable<Event>> GetUpcomingEventsSortedByPopularity();
    }
}
