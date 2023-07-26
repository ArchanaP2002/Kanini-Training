
using ApiProject.DataAccess;
using Microsoft.EntityFrameworkCore;
namespace ApiProject.Model_s
{
    public class Category //represents  category entity
    {
        public int Id { get; set; } // Property
        public string CategoryName { get; set; }
    }
}
