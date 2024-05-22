using AutoMapper;
using EventSphereManagement.DTOs;
using EventSphereManagement.Models;
using EventSphereManagement.Repositories.Implementations;
using EventSphereManagement.Repositories.Interfaces;
using EventSphereManagement.Services.Interfaces;

namespace EventSphereManagement.Services.Implementations
{
    public class AttendeeService : IAttendeeService

    {
        public readonly IAttendeeRepository _repository;
        private readonly IMapper _mapper;


        public AttendeeService(IAttendeeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AttendeeDTO> GetAttendeeById(int attendeeId)
        {
            var attendee = await _repository.GetAttendeeById(attendeeId);
            if (attendee == null)
            {
                throw new KeyNotFoundException("Attendee not found");
            }
            return _mapper.Map<AttendeeDTO>(attendee);
        }

        public async Task<IEnumerable<AttendeeDTO>> GetAllAttendees()
        {
            var attendees = await _repository.GetAllAttendees();
            var response = attendees?.Select(element =>
            {
                AttendeeDTO attendeeDto = new AttendeeDTO();
                return _mapper.Map(element, attendeeDto);
            });
            return response;
        }

        //public async Task RegisterAttendee(AttendeeDTO attendeeDto)
        //{
        //    var attendee = _mapper.Map<Attendee>(attendeeDto);
        //    await _repository.Add(attendee);
        //}

        public async Task UpdateAttendee(AttendeeDTO attendeeDto, int attendeeId)
        {
            await _repository.UpdateAttendee(attendeeDto, attendeeId);
        }

        public async Task RemoveAttendee(int attendeeId)
        {
             await _repository.DeleteAttendee(attendeeId);
            
        }

        public async Task<IEnumerable<AttendeeDTO>> GetAttendeesByEvent(int eventId)
        {
            var attendees = await _repository.GetByEventIdAsync(eventId);
            var response = attendees?.Select(element =>
            {
                AttendeeDTO attendeeDto = new AttendeeDTO();
                return _mapper.Map(element, attendeeDto);
            });
            return response;
        }

        public async Task CheckInAttendee(int eventId, int attendeeId)
        {
            await _repository.CheckInAsync(eventId, attendeeId);
        }
    }
}

