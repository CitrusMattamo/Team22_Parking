using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Team22_Parking.Models;

namespace Team22_Parking.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<ParkingLot> ParkingLots { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<ParkingLot>().ToTable("ParkingLot");
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
        }
    }
}
