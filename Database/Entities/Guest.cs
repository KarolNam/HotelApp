using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Database.Entities;

[Table("Guests")]
public class Guest : BaseEntity
{
  [StringLength(50)]
  [MinLength(1, ErrorMessage = "Min length should be 1")]
  public required string FirstName { get; set; }
  [StringLength(50)]
  [MinLength(1, ErrorMessage = "Min length should be 1")]
  public required string LastName { get; set; }
  [StringLength(50)]
  [EmailAddress(ErrorMessage = "Invalid email address")]
  public required string Email { get; set; }
  [StringLength(12)]
  [Phone(ErrorMessage = "Invalid phone number")]
  [MinLength(9, ErrorMessage = "Min length should be 9")]
  public required string Phone { get; set; }

  public ICollection<Reservation> Reservations { get; set; } = [];
}