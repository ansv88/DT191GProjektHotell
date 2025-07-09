using System.ComponentModel.DataAnnotations;

namespace DT191GProjektHotell.Models;

public class ContactModel
{
    [Key]
    public int ContactId { get; set; }

    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    public string LastName { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    public string Subject { get; set; } = string.Empty;

    [Required]
    public string Message { get; set; } = string.Empty;

    public DateTime Created { get; set; } = DateTime.Now;

    public bool IsRead { get; set; } = false;

    public bool IsAnswered { get; set; } = false;
}