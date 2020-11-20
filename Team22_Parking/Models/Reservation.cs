using System;
using System.Collections.Generic;

namespace Team22_Parking.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int LotId { get; set; }
        public int MemberId { get; set; }
        public ParkingLot ParkingLot { get; set; }
        public Member Member { get; set; }
    }
}
