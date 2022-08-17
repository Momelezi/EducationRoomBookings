using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class InterventionType
    {
        public int InterventionTypeId { get; set; }
        public string Descr { get; set; }
        public bool Activity { get; set; }
        public virtual ICollection<InterventionTypeBooking> InterventionTypeBookings {
            get => InterventionTypeBookings ?? (InterventionTypeBookings = new List<InterventionTypeBooking>());
            set => InterventionTypeBookings = value;
        }
    }
}
