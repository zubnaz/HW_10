using _06_02_EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_02_EntityFramework.Helpers
{
    public static class DBInitializer
    {
        public static void SeedAirplane(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airplane>().HasData(new Airplane[]
            {
                new Airplane()
                {
                     Id = 1, Model = "Boeing 727", MaxPassangers = 120 , AirplaneTypesId = 1, CityId = 1
                },
                new Airplane()
                {
                     Id = 2, Model = "Am 727", MaxPassangers = 90 , AirplaneTypesId = 1, CityId = 1
                }
            });
        }
        public static void SeedAirplaneTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirplaneTypes>().HasData(new AirplaneTypes[]
            {
                new AirplaneTypes()
                {
                     Id = 1, Name = "Passangers Airplane"
                }
            });
        }
        public static void SeedCities(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(new City[]
            {
                new City()
                {
                     Id = 1, Name = "Kyiv",CountriesId = 1
                },
                new City()
                {
                     Id = 2, Name = "Lviv",CountriesId = 1
                }
            });
        }
        public static void SeedCountries(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Countries>().HasData(new Countries[]
            {
                new Countries()
                {
                     Id = 1, Name = "Ukraine"
                }
            });
        }
        
        public static void SeedAccounts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>().HasData(new Accounts[]
            {
                new Accounts()
                {
                     Id = 1, Nickname = "Nazar", Password = "abc123"
                },
                new Accounts()
                {
                     Id = 2, Nickname = "Max", Password = "123abc"
                }
            });
        }
        public static void SeedClients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(new Client[]
            {
                new Client()
                {
                     AccountsId = 1, Name = "Nazar",Email="Nazarko123@gmail.com"
                },
                new Client()
                {
                     AccountsId = 2, Name = "Maxum",Email="Maxumko123@gmail.com"
                }
            });
        }
        public static void SeedFlights(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>().HasData(new Flight[]
            {
                new Flight()
                {
                     Number = 1,
                     ArrivelTime = new DateTime(2023,3,20),
                     DepartureTime = new DateTime(2023,3,20),
                     ArrivelCity = "Kyiv",
                     DepartureCity = "Lviv",
                     AirplaneId = 1,
                     CityId = 1

                },
                new Flight()
                {
                      Number = 2,
                      ArrivelTime = new DateTime(2023,3,20),
                      DepartureTime = new DateTime(2023,3,20),
                      ArrivelCity = "Lviv",
                      DepartureCity = "Warshaw",
                      AirplaneId = 2,
                      CityId = 2
                }
            });
        }
    }
}
