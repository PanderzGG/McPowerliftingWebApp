using System.ComponentModel.DataAnnotations;

namespace MudCowV2.Models.SignInEntities
{
    public class SignInModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
