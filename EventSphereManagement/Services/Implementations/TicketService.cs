using EventSphereManagement.DTOs;
using EventSphereManagement.Services.Interfaces;

namespace EventSphereManagement.Services.Implementations
{
    public class TicketService : ITicketService
    {
        public Task<decimal> CalculateRevenueForEvent(int eventId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketDTO>> CheckTicketAvailability(int eventId)
        {
            throw new NotImplementedException();
        }

        public Task<TicketDTO> GetTicketById(int ticketId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketDTO>> GetTicketsForEvent(int eventId)
        {
            throw new NotImplementedException();
        }

        public Task RefundTicket(int ticketId)
        {
            throw new NotImplementedException();
        }

        public Task SellTicket(TicketDTO ticketDto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTicket(TicketDTO ticketDto, int ticketId)
        {
            throw new NotImplementedException();
        }
    }
}
