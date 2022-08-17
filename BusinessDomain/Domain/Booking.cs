using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime DurationStart { get; set; }
        public DateTime DurationEnd { get; set; }
        public DateTime? PreparationDate { get; set; }
        public int Requestor { get; set; }
        public int ResponsiblePerson { get; set; }
        public int? ResponsibleDirector { get; set; }
        public  int? UnitManager { get; set; }
        public int? BranchId { get; set; }
        public int? DirectorateId { get; set; }
        public int? ComponentId { get; set; }
        public string Comment { get; set; }
        public int? DesignationId { get; set; }

        public  Branch Branch { get; set; }
        public virtual ICollection<EquipmentBooking> EquipmentBookings {
            get => EquipmentBookings ?? (EquipmentBookings = new List<EquipmentBooking>());
            set => EquipmentBookings = value;
        }
        public virtual ICollection<InterventionTypeBooking> InterventionTypeBookings {
            get => InterventionTypeBookings ?? (InterventionTypeBookings = new List<InterventionTypeBooking>());
            set => InterventionTypeBookings = value;
        }
        public virtual ICollection<TargetAudienceBooking> TargetAudienceBookings {
            get => TargetAudienceBookings ?? (TargetAudienceBookings = new List<TargetAudienceBooking>());
            set => TargetAudienceBookings = value;
        }
        public virtual ICollection<VenueBooking> VenueBookings {
            get => VenueBookings ?? (VenueBookings = new List<VenueBooking>());
            set => VenueBookings = value;
        }



    }
}
