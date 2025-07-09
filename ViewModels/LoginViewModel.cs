using System.ComponentModel.DataAnnotations;

namespace DT191GProjektHotell.ViewModels;

public class LoginViewModel
{
    [Required(ErrorMessage = "Användarnamn krävs")]
    public string UserName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Lösenord krävs")]
    public string Password { get; set; } = string.Empty;
}