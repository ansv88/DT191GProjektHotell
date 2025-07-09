using System.ComponentModel.DataAnnotations;

namespace DT191GProjektHotell.ViewModels;

public class ReviewViewModel
{
    [Required]
    public int BookingId { get; set; }
    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;
    [Required, Range(1, 5)]
    public int Rating { get; set; }
    [Required]
    public string Comment { get; set; } = string.Empty;
    public string? Name { get; set; }
}