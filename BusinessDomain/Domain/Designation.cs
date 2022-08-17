using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Designation
    {
        public int DesignationId { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Booking> Bookings
        {
            get => Bookings ?? (Bookings = new List<Booking>());
            set => Bookings = value;
        }
    }
}
