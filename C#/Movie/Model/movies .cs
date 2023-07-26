using System.ComponentModel.DataAnnotations;

namespace Movie.Model
{
    public class movies
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        //public DateTime ReleaseDate { get; set; }
        public TimeOnly duration { get; set; }

    }
}
/*  id INT PRIMARY KEY AUTO_INCREMENT,
  title VARCHAR(100) NOT NULL,
  release_date DATE NOT NULL,
  duration_min INT NOT NULL,
  genre VARCHAR(50),
  rating VARCHAR(10)*/
