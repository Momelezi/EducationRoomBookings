using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string OfficeNumber { get; set; }
        public int DirectorateId { get; set; }
        public virtual ICollection<Booking> Bookings {
            get => Bookings ?? (Bookings = new List<Booking>());
            set => Bookings = value;
        }
        public virtual ICollection<Booking> Bookings1 {
            get => Bookings1 ?? (Bookings1 = new List<Booking>());
            set => Bookings1 = value;
        }
        public virtual ICollection<Booking> Bookings2 {
            get => Bookings2 ?? (Bookings2 = new List<Booking>());
            set => Bookings2 = value;
        }
        public virtual ICollection<Booking> Bookings3 {
            get => Bookings3 ?? (Bookings3 = new List<Booking>());
            set => Bookings3 = value;
        }
        public virtual Directorate Directorates {
            get => Directorates ?? (Directorates = new List<Directorate>());
            set => Directorates = value;
        }
    }
}
