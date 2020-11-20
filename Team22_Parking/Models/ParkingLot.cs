using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team22_Parking.Models
{
    public class ParkingLot
    {
        public int Id { get; set; }
        public string LotName { get; set; }
        public int TotalSpaces { get; set; }
        public int AvailbleSpaces { get; set; }
        public ICollection<Reservation> Reservations { get; set; }


    }
}
