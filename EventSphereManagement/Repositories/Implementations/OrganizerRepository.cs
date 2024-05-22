using EventSphereManagement.Models;
using EventSphereManagement.Repositories.Interfaces;

namespace EventSphereManagement.Repositories.Implementations
{
    public class OrganizerRepository : IOrganizerRepository
    {
        public Task AddOrganizer(Organizer organizer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrganizer(int organizerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Organizer>> GetAllOrganizers()
        {
            throw new NotImplementedException();
        }

        public Task<Organizer> GetOrganizerById(int organizerId)
        {
            throw new NotImplementedException();
        }


        public Task UpdateOrganizer(Organizer organizer, int organizerId)
        {
            throw new NotImplementedException();
        }
    }
}
