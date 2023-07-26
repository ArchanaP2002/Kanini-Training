using System.ComponentModel.DataAnnotations;

namespace FitnessApi.model_s
{
    public class Users
    {
        [Key]
        public int userId { get; set; }

        //public string? UserName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}
