using Figma.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Figma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly FigmaContext _context;

        public LoginController(FigmaContext context)
        {
            _context = context;
        }

        [HttpGet] // Read from Data base 
        public IActionResult Get()
        {
            try
            {
                var user = _context.customer.ToList();//property to get all list 
                if (user.Count == 0)
                {
                    return NotFound("Not available.");
                }
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
