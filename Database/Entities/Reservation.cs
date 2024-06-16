using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Database.Entities;

[Table("Reservations")]
public class Reservation : BaseEntity
{
  [ForeignKey("Guest")]
  [Range(1, int.MaxValue, ErrorMessage = " Select guest!")]
  public int GuestId { get; set; }
  [ForeignKey("Room")]
  [Range(1, int.MaxValue, ErrorMessage = " Select room!")]
  public int RoomId { get; set; }
  public DateTime CheckInDate { get; set; }
  [DataType(DataType.DateTime, ErrorMessage = "Set check out date")]
  public DateTime CheckOutDate { get; set; }
  public double TotalPrice { get; set; }

  public virtual Guest? Guest { get; set; }
  public virtual Room? Room { get; set; }
  public virtual Invoice? Invoice { get; set; }
  public ICollection<Service> Services { get; set; } = [];
  public ICollection<ReservationServices> ReservationServices { get; set; } = [];
}