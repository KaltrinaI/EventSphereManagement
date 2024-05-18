using EventSphereManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EventSphereManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<EventAttendees> EventAttendees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships and keys here
            modelBuilder.Entity<EventAttendees>().HasKey(ea => new { ea.EventId, ea.AttendeeId });

            modelBuilder.Entity<EventAttendees>()
                .HasOne<Event>(ea => ea.Event)
                .WithMany(e => e.EventAttendees)
                .HasForeignKey(ea => ea.EventId);

            modelBuilder.Entity<EventAttendees>()
                .HasOne<Attendee>(ea => ea.Attendee)
                .WithMany(a => a.EventAttendees)
                .HasForeignKey(ea => ea.AttendeeId);
        }
    }

}

