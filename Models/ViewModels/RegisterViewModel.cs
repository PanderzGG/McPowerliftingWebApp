using System.ComponentModel.DataAnnotations;

namespace MCPowerlifting.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "E-mail is required")]
        public string? Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "User Name is required")]
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        public string? ConfirmPassword { get; set; }

        public string? Role { get; set; }

        public string? passwordHash { get; set; }
    }
}
