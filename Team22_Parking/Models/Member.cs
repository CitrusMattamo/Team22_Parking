using System;
using System.Collections.Generic;

namespace Team22_Parking.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
