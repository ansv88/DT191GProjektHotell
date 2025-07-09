using System.ComponentModel.DataAnnotations;

namespace DT191GProjektHotell.ViewModels;

public class BookingViewModel : IValidatableObject
{
    public int RoomId { get; set; }

    [Required(ErrorMessage = "Vänligen välj en rumstyp.")]
    public string RoomType { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vänligen ange check-in datum.")]
    [DataType(DataType.Date)]
    public DateTime? CheckInDate { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "Vänligen ange check-out datum.")]
    [DataType(DataType.Date)]
    public DateTime? CheckOutDate { get; set; } = DateTime.Today.AddDays(1);

    [Required(ErrorMessage = "Ange antal vuxna.")]
    [Range(1, 10, ErrorMessage = "Minst 1 vuxen krävs.")]
    public int Adults { get; set; } = 1;

    [Required(ErrorMessage = "Ange antal barn.")]
    [Range(0, 10, ErrorMessage = "Antal barn kan inte vara negativt.")]
    public int Children { get; set; } = 0;

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

    [Required(ErrorMessage = "Vänligen ange ett telefonnummer.")]
    [RegularExpression(@"^\d+$", ErrorMessage = "Telefonnumret får enbart bestå av siffror.")]
    [StringLength(20, ErrorMessage = "Telefonnumret får vara max 20 tecken.")]
    public string PhoneNumber { get; set; } = string.Empty;

    [StringLength(1000, MinimumLength = 10, ErrorMessage = "Meddelandet måste vara mellan 10 och 1000 tecken.")]
    public string? Note { get; set; }

    // Ytterligare validering
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        if (CheckInDate.HasValue && CheckOutDate.HasValue)
        {
            if (CheckInDate.Value < DateTime.Today)
            {
                results.Add(new ValidationResult(
                    "Check-in datum kan inte vara tidigare än idag.",
                    new[] { nameof(CheckInDate) }));
            }

            if (CheckOutDate.Value <= CheckInDate.Value)
            {
                results.Add(new ValidationResult(
                    "Check-out datum måste vara efter check-in datum.",
                    new[] { nameof(CheckOutDate) }));
            }

            if (CheckInDate.HasValue && (CheckOutDate.Value - CheckInDate.Value).TotalDays > 30)
            {
                results.Add(new ValidationResult(
                    "Bokningsperioden kan inte vara längre än 30 dagar.",
                    new[] { nameof(CheckOutDate) }));
            }
        }

        if (Adults + Children > 10)
        {
            results.Add(new ValidationResult(
                "Totalt antal gäster kan inte överstiga 10 personer.",
                new[] { nameof(Adults), nameof(Children) }));
        }

        return results;
    }
}