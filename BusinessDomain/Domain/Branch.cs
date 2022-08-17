using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Branch
    {
       
        public int BranchId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Booking> Bookings
        {
            get => Bookings ?? (Bookings = new List<Booking>());
            set => Bookings = value;
        }

    }
}
