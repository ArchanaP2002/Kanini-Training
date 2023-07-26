using System.ComponentModel.DataAnnotations;

namespace Authorization.Autzh
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name Required")]
        public  string? Username { get; set; } // ? for nullable 

        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "pwd Required")]
        public string Password { get; set; } = string.Empty;
    }
}
