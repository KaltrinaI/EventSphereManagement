using EventSphereManagement.DTOs;

namespace EventSphereManagement.Services.Interfaces
{
    public interface ITicketService
    {
        Task<TicketDTO> GetTicketById(int ticketId);
        Task<IEnumerable<TicketDTO>> GetTicketsForEvent(int eventId);
        Task<IEnumerable<TicketDTO>> CheckTicketAvailability(int eventId);
        Task<decimal> CalculateRevenueForEvent(int eventId);
        Task SellTicket(TicketDTO ticketDto);
        Task UpdateTicket(TicketDTO ticketDto, int ticketId);
        Task RefundTicket(int ticketId);
    }
}

