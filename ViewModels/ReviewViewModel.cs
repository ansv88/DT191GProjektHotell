using System.ComponentModel.DataAnnotations;

namespace DT191GProjektHotell.ViewModels;

public class ReviewViewModel
{
    [Required(ErrorMessage = "Bokningsnummer kr�vs.")]
    public int BookingId { get; set; }

    [Required(ErrorMessage = "V�nligen ange den e-postadress du anv�nde vid bokning.")]
    [EmailAddress(ErrorMessage = "Ange en giltig e-postadress.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "V�nligen ge ett betyg.")]
    [Range(1, 5, ErrorMessage = "Betyget m�ste vara mellan 1 och 5 stj�rnor.")]
    public int Rating { get; set; }

    [Required(ErrorMessage = "V�nligen skriv en kommentar.")]
    [StringLength(1000, MinimumLength = 10, ErrorMessage = "Kommentaren m�ste vara mellan 10 och 1000 tecken.")]
    public string Comment { get; set; } = string.Empty;

    [StringLength(100, ErrorMessage = "Namnet f�r vara max 100 tecken.")]
    public string? Name { get; set; }
}