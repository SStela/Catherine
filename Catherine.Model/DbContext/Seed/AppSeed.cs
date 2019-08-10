using System;
using Catherine.Model.Cities;
using Catherine.Model.Citizens;
using Catherine.Model.Citizenships;
using Catherine.Model.Countries;
using Microsoft.EntityFrameworkCore;

namespace Catherine.Model.DbContext.Seed
{
    public static class AppSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Citizens(modelBuilder);
            Countries(modelBuilder);
            Citizenships(modelBuilder);
            Cities(modelBuilder);
        }

        public static void Citizenships(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Citizenship>().HasData(
                new Citizenship()
                {
                    CitizenId = 1,
                    CountryId = 3
                },
                new Citizenship()
                {
                    CitizenId = 2,
                    CountryId = 3
                },
                new Citizenship()
                {
                    CitizenId = 3,
                    CountryId = 1
                }
            );
        }

        public static void Countries(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country()
                {
                    Id = 1,
                    Name = "Croatia"
                },
                new Country()
                {
                    Id = 2,
                    Name = "USA"
                },
                new Country()
                {
                    Id = 3,
                    Name = "Germany"
                }
            );
        }

        public static void Cities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    Id = 1,
                    Name = "Zagreb",
                    CountryId = 1
                },
                new City()
                {
                    Id = 2,
                    Name = "Karlovac",
                    CountryId = 1
                },
                new City()
                {
                    Id = 3,
                    Name = "Berlin",
                    CountryId = 3
                }
            );
        }

        public static void Citizens(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Citizen>().HasData(
                new Citizen()
                {
                    Id = 1,
                    VatNumber = "11111111111",
                    FirstName = "Albert",
                    LastName = "Einstein",
                    Birthdate = DateTime.Parse("1879-03-14"),
                    Paycheck = 15000.00m
                },
                new Citizen()
                {
                    Id = 2,
                    VatNumber = "11111111112",
                    FirstName = "Max",
                    LastName = "Planck",
                    Birthdate = DateTime.Parse("1858-04-23"),
                    Paycheck = 14000.00m
                },
                new Citizen()
                {
                    Id = 3,
                    VatNumber = "11111111113",
                    FirstName = "Pero",
                    LastName = "Peric",
                    Birthdate = DateTime.Parse("1995-01-01"),
                    Paycheck = 16000.00m
                }
            );
        }
    }
}