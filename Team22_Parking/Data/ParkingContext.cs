using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Team22_Parking.Models;

namespace Team22_Parking.Data
{
    public class ParkingContext : DbContext
    {
        public ParkingContext (DbContextOptions<ParkingContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
    }
}
