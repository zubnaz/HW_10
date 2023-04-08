﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _06_02_EntityFramework;

namespace HW_10.Migrations
{
    [DbContext(typeof(AirplaneDbContext))]
    [Migration("20230408102401_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClientFlight", b =>
                {
                    b.Property<int>("ClientsAccountsId")
                        .HasColumnType("int");

                    b.Property<int>("FlightsNumber")
                        .HasColumnType("int");

                    b.HasKey("ClientsAccountsId", "FlightsNumber");

                    b.HasIndex("FlightsNumber");

                    b.ToTable("ClientFlight");
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.Accounts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nickname = "Nazar",
                            Password = "abc123"
                        },
                        new
                        {
                            Id = 2,
                            Nickname = "Max",
                            Password = "123abc"
                        });
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.Airplane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirplaneTypesId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("MaxPassangers")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AirplaneTypesId");

                    b.HasIndex("CityId");

                    b.ToTable("Airplanes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AirplaneTypesId = 1,
                            CityId = 1,
                            MaxPassangers = 120,
                            Model = "Boeing 727"
                        },
                        new
                        {
                            Id = 2,
                            AirplaneTypesId = 1,
                            CityId = 1,
                            MaxPassangers = 90,
                            Model = "Am 727"
                        });
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.AirplaneTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("AirplaneTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Passangers Airplane"
                        });
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountriesId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CountriesId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountriesId = 1,
                            Name = "Kyiv"
                        },
                        new
                        {
                            Id = 2,
                            CountriesId = 1,
                            Name = "Lviv"
                        });
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.Client", b =>
                {
                    b.Property<int>("AccountsId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("FirstName");

                    b.HasKey("AccountsId");

                    b.ToTable("Passengers");

                    b.HasData(
                        new
                        {
                            AccountsId = 1,
                            Email = "Nazarko123@gmail.com",
                            Name = "Nazar"
                        },
                        new
                        {
                            AccountsId = 2,
                            Email = "Maxumko123@gmail.com",
                            Name = "Maxum"
                        });
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ukraine"
                        });
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.Flight", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirplaneId")
                        .HasColumnType("int");

                    b.Property<string>("ArrivelCity")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ArrivelTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("DepartureCity")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Number");

                    b.HasIndex("AirplaneId");

                    b.HasIndex("CityId");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            Number = 1,
                            AirplaneId = 1,
                            ArrivelCity = "Kyiv",
                            ArrivelTime = new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 1,
                            DepartureCity = "Lviv",
                            DepartureTime = new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Number = 2,
                            AirplaneId = 2,
                            ArrivelCity = "Lviv",
                            ArrivelTime = new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = 2,
                            DepartureCity = "Warshaw",
                            DepartureTime = new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ClientFlight", b =>
                {
                    b.HasOne("_06_02_EntityFramework.Entities.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsAccountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_06_02_EntityFramework.Entities.Flight", null)
                        .WithMany()
                        .HasForeignKey("FlightsNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.Airplane", b =>
                {
                    b.HasOne("_06_02_EntityFramework.Entities.AirplaneTypes", "AirplaneTypes")
                        .WithMany("Airplane")
                        .HasForeignKey("AirplaneTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_06_02_EntityFramework.Entities.City", "City")
                        .WithMany("Airplanes")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirplaneTypes");

                    b.Navigation("City");
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.City", b =>
                {
                    b.HasOne("_06_02_EntityFramework.Entities.Countries", "Countries")
                        .WithMany("Cities")
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Countries");
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.Client", b =>
                {
                    b.HasOne("_06_02_EntityFramework.Entities.Accounts", "Accounts")
                        .WithOne("Client")
                        .HasForeignKey("_06_02_EntityFramework.Entities.Client", "AccountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.Flight", b =>
                {
                    b.HasOne("_06_02_EntityFramework.Entities.Airplane", "Airplane")
                        .WithMany("Flights")
                        .HasForeignKey("AirplaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_06_02_EntityFramework.Entities.City", "Cities")
                        .WithMany("Flight")
                        .HasForeignKey("CityId");

                    b.Navigation("Airplane");

                    b.Navigation("Cities");
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.Accounts", b =>
                {
                    b.Navigation("Client");
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.Airplane", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.AirplaneTypes", b =>
                {
                    b.Navigation("Airplane");
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.City", b =>
                {
                    b.Navigation("Airplanes");

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("_06_02_EntityFramework.Entities.Countries", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
