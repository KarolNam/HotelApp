using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Database.Entities;

[Table("Rooms")]
public class Room : BaseEntity
{
  [Column("RoomNumber")]
  [MaxLength(3, ErrorMessage = "Max length should be 3")]
  [MinLength(1, ErrorMessage = "Min length should be 1")]
  public required string RoomNumber { get; set; }
  [Column("RoomType")]
  [MinLength(1, ErrorMessage = "Select type of room")]
  public required string Type { get; set; }
  public double PricePerNight { get; set; }
  [Column("Available")]
  public bool IsAvailable { get; set; } = true;

  public ICollection<Reservation> Reservations { get; set; } = [];
}