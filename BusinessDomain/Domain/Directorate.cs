using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Directorate
    {
        public int DirectorateId { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public virtual ICollection<Booking> Bookings
        {
            get => Bookings ?? (Bookings = new List<Booking>());
            set => Bookings = value;
        }
        public virtual ICollection<Person> People
        {
            get => People ?? (People = new List<Person>());
            set => People = value;
        }
    }
}
