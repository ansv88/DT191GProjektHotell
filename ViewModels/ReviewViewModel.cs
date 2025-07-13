using System.ComponentModel.DataAnnotations;

namespace DT191GProjektHotell.ViewModels;

public class ReviewViewModel
{
    [Required(ErrorMessage = "Bokningsnummer krävs.")]
    public int BookingId { get; set; }

    [Required(ErrorMessage = "Vänligen ange den e-postadress du använde vid bokning.")]
    [EmailAddress(ErrorMessage = "Ange en giltig e-postadress.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vänligen ge ett betyg.")]
    [Range(1, 5, ErrorMessage = "Betyget måste vara mellan 1 och 5 stjärnor.")]
    public int Rating { get; set; }

    [Required(ErrorMessage = "Vänligen skriv en kommentar.")]
    [StringLength(1000, MinimumLength = 10, ErrorMessage = "Kommentaren måste vara mellan 10 och 1000 tecken.")]
    public string Comment { get; set; } = string.Empty;

    [StringLength(100, ErrorMessage = "Namnet får vara max 100 tecken.")]
    public string? Name { get; set; }
}