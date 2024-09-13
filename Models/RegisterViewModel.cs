using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Models
{
  public class RegisterViewModel
  {
    [Required(ErrorMessage = "Username is required.")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    public string Password { get; set; }
  }
}