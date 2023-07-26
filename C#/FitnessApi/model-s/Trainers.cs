using System.ComponentModel.DataAnnotations;

namespace FitnessApi.model_s
{
    public class Trainers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Specialist { get; set; }

    }
}
