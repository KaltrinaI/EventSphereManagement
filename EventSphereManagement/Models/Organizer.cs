﻿using System.ComponentModel.DataAnnotations;

namespace EventSphereManagement.Models
{
    public class Organizer
    {
        [Key]
        public int OrganizerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
