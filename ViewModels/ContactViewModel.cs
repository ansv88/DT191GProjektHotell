using System.ComponentModel.DataAnnotations;

namespace DT191GProjektHotell.ViewModels;

public class ContactViewModel
{
    [Required(ErrorMessage = "V�nligen ange ditt f�rnamn.")]
    [StringLength(50, ErrorMessage = "F�rnamnet f�r vara max 50 tecken.")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "V�nligen ange ditt efternamn.")]
    [StringLength(50, ErrorMessage = "Efternamnet f�r vara max 50 tecken.")]
    public string LastName { get; set; } = string.Empty;

    [Required(ErrorMessage = "V�nligen ange en e-postadress.")]
    [EmailAddress(ErrorMessage = "Ange en giltig e-postadress.")]
    [StringLength(100, ErrorMessage = "E-postadressen f�r vara max 100 tecken.")]
    public string Email { get; set; } = string.Empty;

    [RegularExpression(@"^\d+$", ErrorMessage = "Telefonnumret f�r enbart best� av siffror.")]
    [StringLength(20, ErrorMessage = "Telefonnumret f�r vara max 20 tecken.")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "V�nligen ange ett �mne.")]
    [StringLength(100, ErrorMessage = "�mnet f�r vara max 100 tecken.")]
    public string Subject { get; set; } = string.Empty;

    [Required(ErrorMessage = "V�nligen skriv ett meddelande.")]
    [StringLength(1000, MinimumLength = 10, ErrorMessage = "Meddelandet m�ste vara mellan 10 och 1000 tecken.")]
    public string Message { get; set; } = string.Empty;
}