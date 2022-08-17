using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class EquipmentBooking
    {
        public int EquipmentBookingId { get; set; }
        public int EquipmentId { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
