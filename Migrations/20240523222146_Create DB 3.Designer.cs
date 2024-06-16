﻿// <auto-generated />
using System;
using HotelApp.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240523222146_Create DB 3")]
    partial class CreateDB3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelApp.Database.Entities.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("Id");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("HotelApp.Database.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuestId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("HotelApp.Database.Entities.ReservationService", b =>
                {
                    b.Property<int>("ReservationId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("ServiceId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ReservationId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ReservationServices");
                });

            modelBuilder.Entity("HotelApp.Database.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit")
                        .HasColumnName("Available");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("float");

                    b.Property<string>("RoomNumber")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("RoomNumber");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RoomType");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HotelApp.Database.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ServiceName");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("ServicePrice");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("HotelApp.Database.Entities.Reservation", b =>
                {
                    b.HasOne("HotelApp.Database.Entities.Guest", "Guest")
                        .WithMany("Reservations")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelApp.Database.Entities.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HotelApp.Database.Entities.ReservationService", b =>
                {
                    b.HasOne("HotelApp.Database.Entities.Reservation", "Reservation")
                        .WithMany("ReservationServices")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelApp.Database.Entities.Service", "Service")
                        .WithMany("ReservationServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("HotelApp.Database.Entities.Guest", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("HotelApp.Database.Entities.Reservation", b =>
                {
                    b.Navigation("ReservationServices");
                });

            modelBuilder.Entity("HotelApp.Database.Entities.Room", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("HotelApp.Database.Entities.Service", b =>
                {
                    b.Navigation("ReservationServices");
                });
#pragma warning restore 612, 618
        }
    }
}
