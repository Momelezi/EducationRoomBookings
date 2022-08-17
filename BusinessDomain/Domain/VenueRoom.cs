using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class VenueRoom
    {
        public int VenueRoomId { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Venue> Venues {
            get => Venues ?? (Venues = new List<Venue>());
            set => Venues = value;
        }
    }
}
