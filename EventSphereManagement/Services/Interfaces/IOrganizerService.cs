using EventSphereManagement.DTOs;

namespace EventSphereManagement.Services.Interfaces
{
    public interface IOrganizerService
    {
        Task<OrganizerDTO> GetOrganizerById(int organizerId);
        Task<IEnumerable<OrganizerDTO>> GetAllOrganizers();
        Task CreateOrganizer(OrganizerDTO organizerDto);
        Task UpdateOrganizer(OrganizerDTO organizerDto, int organizerId);
        Task DeleteOrganizer(int organizerId);
    }
}
