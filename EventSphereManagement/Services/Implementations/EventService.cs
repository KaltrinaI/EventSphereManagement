using AutoMapper;
using EventSphereManagement.DTOs;
using EventSphereManagement.Models;
using EventSphereManagement.Repositories.Interfaces;
using EventSphereManagement.Services.Interfaces;

namespace EventSphereManagement.Services.Implementations
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _repository;
        private readonly IMapper _mapper;

        public EventService(IEventRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task AddEvent(EventRequestDTO eventDto)
        {
            var requestedEvent = _mapper.Map<EventRequestDTO>(eventDto);
            await _repository.AddEvent(requestedEvent);

        }

        public async Task DeleteEvent(int eventId)
        {
            var eventEntity = await _repository.GetEventById(eventId);
            if (eventEntity == null)
            {
                throw new KeyNotFoundException("Event not found");
            }

            await _repository.DeleteEvent(eventId);
        }

        public async Task<IEnumerable<EventDTO>> GetAllEvents()
        {
            var events = await _repository.GetAllEvents();
            return _mapper.Map<IEnumerable<EventDTO>>(events);
        }

        public async Task<EventDTO> GetEventById(int eventId)
        {
            var eventEntity = await _repository.GetEventById(eventId);
            if (eventEntity == null)
            {
                throw new KeyNotFoundException("Event not found");
            }
            return _mapper.Map<EventDTO>(eventEntity);
        }

        public async Task<IEnumerable<EventDTO>> GetEventsByOrganizerId(int organizerId)
        {
            var events = await _repository.GetEventsByOrganizerId(organizerId);
            return _mapper.Map<IEnumerable<EventDTO>>(events);
        }

        public async Task<IEnumerable<EventDTO>> GetUpcomingEventsSortedByPopularity()
        {
            var events = await _repository.GetUpcomingEventsSortedByPopularity();
            return _mapper.Map<IEnumerable<EventDTO>>(events);
        }

        public async Task UpdateEvent(EventDTO eventDto, int eventId)
        {
            if (eventDto == null) throw new ArgumentNullException(nameof(eventDto));

            var existingEvent = await _repository.GetEventById(eventId);
            if (existingEvent == null)
            {
                throw new KeyNotFoundException("Event not found");
            }

            var updatedEvent = _mapper.Map<EventRequestDTO>(existingEvent);
            await _repository.UpdateEvent(updatedEvent, eventId);
        }
    }
}
