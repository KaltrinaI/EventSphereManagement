using EventSphereManagement.Models;

namespace EventSphereManagement.Repositories.Interfaces
{
    public interface ITicketRepository
    {
        Task<Ticket> GetTicketById(int ticketId);
        Task<IEnumerable<Ticket>> GetTicketsByEventId(int eventId);
        Task<IEnumerable<Ticket>> GetAvailableTickets(int eventId);
        Task<decimal> CalculateTotalRevenueFromEvent(int eventId);
        Task AddTicket(Ticket ticket);
        Task UpdateTicket(Ticket ticket, int ticketId);
        Task DeleteTicket(int ticketId);
    }
}
