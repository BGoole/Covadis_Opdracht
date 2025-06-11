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
            modelBuilder.Entity<LeenAuto>().HasData(new LeenAuto { ID = 1, Gereserveerd = false, Type = "Honda Civic", Kenteken = "aa11bc2", GereserveerdVan = new DateTime(2025, 03, 10), GereserveerdTot = new DateTime(2025, 03, 11),  KilometerStand = 1234});
            modelBuilder.Entity<LeenAuto>().HasData(new LeenAuto { ID = 2, Gereserveerd = false, Type = "Fiat Multipla", Kenteken = "mw-99-99", GereserveerdVan = new DateTime(2023, 05, 22), GereserveerdTot = new DateTime(2022, 05, 23), KilometerStand = 1010});
            modelBuilder.Entity<LeenAuto>().HasData(new LeenAuto { ID = 3, Gereserveerd = true, Type = "BMW M5", Kenteken = "qa-12-30", GereserveerdVan = new DateTime(2025, 06, 05), GereserveerdTot = new DateTime(2025, 06, 07), KilometerStand = 500});
            modelBuilder.Entity<Werknemer>().HasData(new Werknemer { ID = 1, Naam = "Mathijs" });
            modelBuilder.Entity<Werknemer>().HasData(new Werknemer { ID = 2, Naam = "Emilio" });
            modelBuilder.Entity<Werknemer>().HasData(new Werknemer { ID = 3, Naam = "Juan" });
        }
    }
}
