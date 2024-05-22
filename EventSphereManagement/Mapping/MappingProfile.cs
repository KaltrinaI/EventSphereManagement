using AutoMapper;
using EventSphereManagement.DTOs;
using EventSphereManagement.Models;

namespace EventSphereManagement.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AttendeeDTO, Attendee>();
            CreateMap<Attendee, AttendeeDTO>();

            CreateMap<EventDTO, Event>();
            CreateMap<Event, EventDTO>();

            CreateMap<EventRequestDTO, Event>();
            CreateMap<Event, EventRequestDTO>();

            CreateMap<AttendeeRequestDTO, Attendee>();
            CreateMap<Attendee, AttendeeRequestDTO>();

            CreateMap<OrganizerDTO, Organizer>();
            CreateMap<Organizer, OrganizerDTO>();

            CreateMap<TicketDTO, Ticket>();
            CreateMap<Ticket, TicketDTO>();
            
        }
    }
}
