using System.ComponentModel.DataAnnotations;

namespace DT191GProjektHotell.Models;

public class CustomerModel
{
    // Egenskaper

    [Key]
    public int CustomerId { get; set; }

    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    public string LastName { get; set; } = string.Empty;

    [Required]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string PhoneNumber { get; set; } = string.Empty;

    public virtual ICollection<BookingModel> Bookings { get; set; } = new List<BookingModel>();
}
