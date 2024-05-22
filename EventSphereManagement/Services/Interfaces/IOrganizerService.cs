using EventSphereManagement.DTOs;

namespace EventSphereManagement.Services.Interfaces
{
    public interface IOrganizerService
    {
        Task<OrganizerDTO> GetOrganizerByIdAsync(int organizerId);
        Task<IEnumerable<OrganizerDTO>> GetAllOrganizersAsync();
        Task CreateOrganizerAsync(OrganizerDTO organizerDto);
        Task UpdateOrganizerAsync(OrganizerDTO organizerDto, int organizerId);
        Task DeleteOrganizerAsync(int organizerId);
    }
}
