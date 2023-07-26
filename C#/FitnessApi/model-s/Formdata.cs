using System.ComponentModel.DataAnnotations;

namespace FitnessApi.model_s
{
    public class Formdata
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public string Comment { get; set; }
    }
}
