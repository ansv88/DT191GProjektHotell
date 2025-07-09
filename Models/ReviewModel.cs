using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DT191GProjektHotell.Models;

public class ReviewModel
{
    [Key]
    public int ReviewId { get; set; }

    [Required]
    public int BookingId { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required, Range(1, 5)]
    public int Rating { get; set; }

    [Required]
    public string Comment { get; set; } = string.Empty;

    public string? Name { get; set; } // Gästens namn, valfritt

    public DateTime Created { get; set; } = DateTime.Now;

    // Navigering (valfritt)
    [ForeignKey("BookingId")]
    public BookingModel? Booking { get; set; }
}
