﻿using System.ComponentModel.DataAnnotations;

namespace EventSphereManagement.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public int EventId { get; set; }
        public decimal Price { get; set; }
        public string TicketType { get; set; }
        public int QuantityAvailable { get; set; }
        public Event Event { get; set; }
    }
}
