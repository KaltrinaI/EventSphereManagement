using EventSphereManagement.Models;

namespace EventSphereManagement.Repositories.Interfaces
{
    public interface IOrganizerRepository
    {
        Task<Organizer> GetOrganizerById(int organizerId);
        Task<IEnumerable<Organizer>> GetAllOrganizers();
        Task AddOrganizer(Organizer organizer);
        Task UpdateOrganizer(Organizer organizer, int organizerId);
        Task DeleteOrganizer(int organizerId);
        
    }
}
