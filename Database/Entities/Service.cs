using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Database.Entities;

[Table("Services")]
public class Service : BaseEntity
{
	[Column("ServiceName")]
	[MinLength(1, ErrorMessage = "Min length should be 1")]
	public required string Name { get; set; }
	[Column("ServicePrice")]
	[Range(1, double.MaxValue, ErrorMessage = "Must be more than 0")]
	public required double Price { get; set; }

	public ICollection<Reservation> Reservations { get; set; } = [];
	public ICollection<ReservationServices> ReservationServices { get; set; } = [];
}