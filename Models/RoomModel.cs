using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DT191GProjektHotell.Models;

public class RoomModel
{
    // Egenskaper

    [Key]
    public int RoomId { get; set; }

    [Required]
    public required string RoomNumber { get; set; } = string.Empty;

    [Required]
    public required string RoomType { get; set; } = string.Empty;

    [Required]
    public int Capacity { get; set; }

    [Required]
    [Precision(18, 2)]
    public decimal Price { get; set; }

    [Required]
    public bool IsAvailable { get; set; }

    // Navigeringsegenskap som representerar bokningar kopplade till rummet
    public virtual ICollection<BookingModel> Bookings { get; set; } = new List<BookingModel>();
}
