﻿// <auto-generated />
using System;
using CovadisLeenAuto.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CovadisLeenAuto.Domain.Migrations
{
    [DbContext(typeof(LeenAutoContext))]
    partial class LeenAutoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("CovadisLeenAuto.Domain.Enitities.LeenAuto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Gereserveerd")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Kenteken")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("KilometerStand")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("LeenAutos");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Gereserveerd = false,
                            Kenteken = "aa11bc2",
                            KilometerStand = 1234,
                            Type = "Honda Civic"
                        },
                        new
                        {
                            ID = 2,
                            Gereserveerd = true,
                            Kenteken = "mw-99-99",
                            KilometerStand = 1010,
                            Type = "Fiat Multipla"
                        });
                });

            modelBuilder.Entity("CovadisLeenAuto.Domain.Enitities.Rit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BeginDatum")
                        .HasColumnType("TEXT");

                    b.Property<string>("EindAdres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EindDatum")
                        .HasColumnType("TEXT");

                    b.Property<int>("KilometerStandBegin")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KilometerStandEind")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StartAdres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("WerknemerID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("WerknemerID");

                    b.ToTable("Ritten");
                });

            modelBuilder.Entity("CovadisLeenAuto.Domain.Enitities.Werknemer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Werknemers");
                });

            modelBuilder.Entity("CovadisLeenAuto.Domain.Enitities.Rit", b =>
                {
                    b.HasOne("CovadisLeenAuto.Domain.Enitities.Werknemer", "Werknemer")
                        .WithMany()
                        .HasForeignKey("WerknemerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Werknemer");
                });
#pragma warning restore 612, 618
        }
    }
}
