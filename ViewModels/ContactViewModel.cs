using System.ComponentModel.DataAnnotations;

namespace DT191GProjektHotell.ViewModels;

public class ContactViewModel
{
    [Required(ErrorMessage = "Vänligen ange ditt förnamn.")]
    [StringLength(50, ErrorMessage = "Förnamnet får vara max 50 tecken.")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vänligen ange ditt efternamn.")]
    [StringLength(50, ErrorMessage = "Efternamnet får vara max 50 tecken.")]
    public string LastName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vänligen ange en e-postadress.")]
    [EmailAddress(ErrorMessage = "Ange en giltig e-postadress.")]
    [StringLength(100, ErrorMessage = "E-postadressen får vara max 100 tecken.")]
    public string Email { get; set; } = string.Empty;

    [RegularExpression(@"^\d+$", ErrorMessage = "Telefonnumret får enbart bestå av siffror.")]
    [StringLength(20, ErrorMessage = "Telefonnumret får vara max 20 tecken.")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vänligen ange ett ämne.")]
    [StringLength(100, ErrorMessage = "Ämnet får vara max 100 tecken.")]
    public string Subject { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vänligen skriv ett meddelande.")]
    [StringLength(1000, MinimumLength = 10, ErrorMessage = "Meddelandet måste vara mellan 10 och 1000 tecken.")]
    public string Message { get; set; } = string.Empty;
}