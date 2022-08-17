using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Descr { get; set; }
        public int EquipmentCategoryId { get; set; }
        public virtual ICollection<EquipmentBooking> EquipmentBookings {
            get => EquipmentBookings ?? (EquipmentBookings = new List<EquipmentBooking>());
            set => EquipmentBookings = value;
        }
    }
}
