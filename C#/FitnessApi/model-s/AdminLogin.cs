using System.ComponentModel.DataAnnotations;

namespace FitnessApi.model_s
{
    public class AdminLogin
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
