using HotelApp.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Database;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
  public DbSet<Guest> Guests { get; set; }
  public DbSet<Room> Rooms { get; set; }
  public DbSet<Reservation> Reservations { get; set; }
  public DbSet<Service> Services { get; set; }
  public DbSet<ReservationServices> ReservationServices { get; set; }
  public DbSet<Invoice> Invoices { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Guest>().HasIndex(g => g.Phone).IsUnique();
        modelBuilder.Entity<Guest>().HasIndex(g => g.Email).IsUnique();
        modelBuilder.Entity<Room>().HasIndex(r => r.RoomNumber).IsUnique();
        modelBuilder.Entity<Service>().HasIndex(s => s.Name).IsUnique();

        modelBuilder.Entity<Guest>().HasMany(g => g.Reservations).WithOne(r => r.Guest);
        modelBuilder.Entity<Room>().HasMany(ro => ro.Reservations).WithOne(r => r.Room);
        modelBuilder.Entity<Reservation>().HasMany(r => r.Services).WithMany(s => s.Reservations);
        modelBuilder.Entity<Reservation>().HasOne(r => r.Invoice).WithOne(i => i.Reservation);

        modelBuilder.Entity<ReservationServices>().HasKey(rs => new { rs.ReservationId, rs.ServiceId });

        modelBuilder.Entity<ReservationServices>()
        .HasOne(rs => rs.Reservation)
        .WithMany(r => r.ReservationServices)
        .HasForeignKey(rs => rs.ReservationId);

        modelBuilder.Entity<ReservationServices>()
        .HasOne(rs => rs.Service)
        .WithMany(r => r.ReservationServices)
        .HasForeignKey(rs => rs.ServiceId);
    }
}