using System.ComponentModel.DataAnnotations;

namespace DT191GProjektHotell.Models;

public class BookingModel
{
    // Egenskaper

    [Key]
    public int BookingId { get; set; }

    public int RoomId { get; set; }

    public int CustomerId { get; set; }

    [Required]
    public DateTime CheckInDate { get; set; }

    [Required]
    public DateTime CheckOutDate { get; set; }

    public string Status { get; set; } = string.Empty; //Bekräftad, Avbokad eller Pågående

    public virtual RoomModel? Room { get; set; }

    public virtual CustomerModel? Customer { get; set; }

    public string? Note { get; set; }
    public int Adults { get; set; }
    public int Children { get; set; }

    public DateTime Created { get; set; } = DateTime.Now;
}
