using System.ComponentModel.DataAnnotations;

namespace Figma.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }

    }
}
