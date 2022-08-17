using BusinessDomain.Domain;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Database
{
    public class BookingDBContext : DbContext
    {
        public BookingDBContext() : base("BookingSystem")
        { }

        public  DbSet<Venue> Venues { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Directorate> Directorates { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentBooking> EquipmentBookings { get; set; }
        public DbSet<EquipmentCategory> EquipmentCategorys { get; set; }
        public DbSet<InterventionType> InterventionTypes { get; set; }
        public DbSet<InterventionTypeBooking> InterventionTypeBookings { get; set; }
        public DbSet<TargetAudience> TargetAudiences { get; set; }
        public DbSet<TargetAudienceBooking> TargetAudienceBookings { get; set; }
        public DbSet<VenueBooking> VenueBookings { get; set; }
        public DbSet<VenueCategory> VenueCategorys { get; set; }
        public DbSet<VenueRoom> VenueRooms { get; set; }


       
    }
}
