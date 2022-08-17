using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public  class TargetAudienceBooking
    {
        public int TargetAudienceBookingId { get; set; }
        public int TargetAudienceId { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual TargetAudience TargetAudience { get; set; }
    }
}
