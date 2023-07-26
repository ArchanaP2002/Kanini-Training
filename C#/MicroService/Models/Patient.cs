using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; set; }
        public string? Specialization { get; set; }
        public string? Reason { get; set; }
    }
}
