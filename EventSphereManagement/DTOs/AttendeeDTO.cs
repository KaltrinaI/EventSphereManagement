﻿namespace EventSphereManagement.DTOs
{
    public class AttendeeDTO
    {
        public int AttendeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int EventId { get; set; }
        public bool IsCheckedIn { get; set; }

    }
}
