using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Database.Entities;

[Table("ReservationServices")]
public class ReservationServices : BaseEntity
{
	[Key]
	[ForeignKey("ReservationId")]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	[Range(1, int.MaxValue, ErrorMessage = " Select reservation")]
	public int ReservationId { get; set; }

	public virtual Reservation? Reservation { get; set; }

	[Key]
	[ForeignKey("ServiceId")]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	[Range(1, int.MaxValue, ErrorMessage = " Select service")]
	public int ServiceId { get; set; }

	public virtual Service? Service { get; set; }

	[Range(1, int.MaxValue, ErrorMessage = "Must be minimum 1")]
	public required int Quantity { get; set; }
}