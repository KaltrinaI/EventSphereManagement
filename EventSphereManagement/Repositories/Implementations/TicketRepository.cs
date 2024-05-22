using EventSphereManagement.Models;
using EventSphereManagement.Repositories.Interfaces;

namespace EventSphereManagement.Repositories.Implementations
{
    public class TicketRepository : ITicketRepository
    {
        public Task AddTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> CalculateTotalRevenueFromEvent(int eventId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTicket(int ticketId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ticket>> GetAvailableTickets(int eventId)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> GetTicketById(int ticketId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ticket>> GetTicketsByEventId(int eventId)
        {
            throw new NotImplementedException();
        }


        public Task UpdateTicket(Ticket ticket, int ticketId)
        {
            throw new NotImplementedException();
        }
    }
}
