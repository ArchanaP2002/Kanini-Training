using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.NewFolder;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudController : ControllerBase

    {
        private static List<Stud> studsList = new List<Stud>
            {
                new Stud  { StudId = 1, Name = "AAA", City = "Chennai",Pin =6006 },
                new Stud  { StudId = 2, Name = "BBB" ,City = "Tuty",Pin =5004 },
                new Stud  { StudId = 3, Name = "CCC" ,City = "TN",Pin =4004 },

            };
        [HttpGet]
        public async Task<ActionResult<List<Stud>>> GetAllStudentDetails()
        {


            return Ok(studsList);
            // var stud = studsList.Where(s => s.StudId =);
        }

        [HttpGet]
        [Route("{id}")] 
        public async Task<ActionResult<List<Stud>>> GetOneStudentDetail(int id)
        {
            var stud = studsList.Where(s => s.StudId ==id).FirstOrDefault();

            if(stud == null)
            {
                return NotFound("Not Matching");
            }
            return Ok(stud);
        }
    }
}
