using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Database.Entities;

[Table("Invoices")]
public class Invoice : BaseEntity
{
    [ForeignKey("ReservationId")]
    [Range(1, int.MaxValue, ErrorMessage = " Select reservation")]
    public int ReservationId { get; set; }

    public DateTime Date { get; set; }

    public double TotalCost { get; set; }

    [MinLength(1, ErrorMessage = "Min length should be 1")]
    public required string Status { get; set; }

    public virtual Reservation? Reservation { get; set; }
}