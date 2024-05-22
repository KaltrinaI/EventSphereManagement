﻿namespace EventSphereManagement.DTOs
{
    public class TicketDTO
    {
        public int TicketId { get; set; }
        public int EventId { get; set; }
        public decimal Price { get; set; }
        public string TicketType { get; set; }
        public int QuantityAvailable { get; set; }
    }
}
