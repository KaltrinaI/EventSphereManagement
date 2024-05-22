using EventSphereManagement.DTOs;
using EventSphereManagement.Services.Interfaces;

namespace EventSphereManagement.Services.Implementations
{
    public class OrganizerService : IOrganizerService
    {
        public Task CreateOrganizer(OrganizerDTO organizerDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrganizer(int organizerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrganizerDTO>> GetAllOrganizers()
        {
            throw new NotImplementedException();
        }

        public Task<OrganizerDTO> GetOrganizerById(int organizerId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrganizer(OrganizerDTO organizerDto, int organizerId)
        {
            throw new NotImplementedException();
        }
    }
}
