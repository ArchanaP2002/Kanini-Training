using FitnessApi.model_s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly FitnessContext _context;

        public RegisterController(FitnessContext context)
        {
            _context = context;
        }
        [HttpGet] // Read from Data base 
        public IActionResult Get()
        {
            try
            {
                var form = _context.Register.ToList();//property to get all list 
                if (form.Count == 0)
                {
                    return NotFound("Not available.");
                }
                return Ok(form);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]// ready by id 
        public IActionResult Get(int id)
        {
            try
            {
                var form = _context.Register.Find(id);
                if (form == null)
                {
                    return NotFound($"Not found with ID: {id}");
                }
                return Ok(form);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost] // Creating
        public IActionResult Post(Register model)
        {
            try
            {
                _context.Add(model); // insert into db
                _context.SaveChanges(); // commit 
                return Ok(" created successfully.");
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occurred.";
                if (ex.InnerException != null)
                {
                    errorMessage += " Inner Exception: " + ex.InnerException.Message;
                }
                return BadRequest(errorMessage);
            }
        }

        [HttpPut] //Update
        public IActionResult Put(Register model)
        {
            try
            {
                if (model == null || model.Id == 0)
                {
                    return BadRequest("Invalid data or ID.");
                }

                var data = _context.Form.Find(model.Id);
                if (data == null)
                {
                    return NotFound($" not found with ID: {model.Id}");
                }

                data.Name = model.Name;

                _context.SaveChanges();

                return Ok("Hotel updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")] //delete by id
        public IActionResult Delete(int id)
        {
            try
            {
                var data = _context.Register.Find(id);
                if (data == null)
                {
                    return NotFound($"not found with ID: {id}");
                }

                
                _context.SaveChanges();

                return Ok(" deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}
