using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovadisLeenAuto.Domain.Enitities;
using Microsoft.EntityFrameworkCore;

namespace CovadisLeenAuto.Domain.Data
{
    public class LeenAutoContext : DbContext
    {
        public LeenAutoContext(DbContextOptions<LeenAutoContext> options) : base(options) { }

        public DbSet<LeenAuto> LeenAutos { get; set; }
        public DbSet<Rit> Ritten { get; set; }
        public DbSet<Werknemer> Werknemers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Todo Database testdata vullen.
            //Entities nodig
            modelBuilder.Entity<LeenAuto>().HasData(new LeenAuto { ID = 1, Gereserveerd = false, Kenteken = "aa11bc2", KilometerStand = 1234, Type = "Honda Civic" });
            modelBuilder.Entity<LeenAuto>().HasData(new LeenAuto { ID = 2, Gereserveerd = true, Kenteken = "mw-99-99", KilometerStand = 1010, Type = "Fiat Multipla" });
        }
    }
}
