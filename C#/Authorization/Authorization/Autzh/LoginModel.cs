using System.ComponentModel.DataAnnotations;

namespace Authorization.Autzh
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Not Found")]
        public string? Username { get; set; } // ? for nullable 


        [Required(ErrorMessage = "pwd Required")]
        public string Password { get; set; } = string.Empty;
    }
}
