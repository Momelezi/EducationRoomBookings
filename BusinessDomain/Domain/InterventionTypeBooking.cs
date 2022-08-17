using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class InterventionTypeBooking
    {
        public int InterventionTypeBookingId { get; set; }
        public int InterventionTypeId { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual InterventionType InterventionType { get; set; }
    }
}
