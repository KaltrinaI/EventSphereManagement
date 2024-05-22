using EventSphereManagement.DTOs;

namespace EventSphereManagement.Services.Interfaces
{
    public interface ITicketService
    {
        Task<TicketDTO> GetTicketByIdAsync(int ticketId);
        Task<IEnumerable<TicketDTO>> GetTicketsForEventAsync(int eventId);
        Task<IEnumerable<TicketDTO>> CheckTicketAvailabilityAsync(int eventId);
        Task<decimal> CalculateRevenueForEventAsync(int eventId);
        Task SellTicketAsync(TicketDTO ticketDto);
        Task UpdateTicketAsync(TicketDTO ticketDto, int ticketId);
        Task RefundTicketAsync(int ticketId);
    }
}

