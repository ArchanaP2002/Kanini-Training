using EmployeeCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var hotel = _context.Employee.ToList();//property to get all list 
                if (hotel.Count == 0)
                {
                    return NotFound("Not available.");
                }
                return Ok(hotel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]// ready by id 
        public IActionResult Get(Guid id)
        {
            try
            {
                var hotel = _context.Employee.Find(id);
                if (hotel == null)
                {
                    return NotFound($"Not found with ID: {id}");
                }
                return Ok(hotel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost] // Creating
        public IActionResult Post(Employee model)
        {
            try
            {
                _context.Add(model); // insert into db
                _context.SaveChanges(); // commit 
                return Ok("created successfully.");
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
        public IActionResult Put(Employee model)
        {
            try
            {
             

                var hotel = _context.Employee.Find(model.Id);
                if (hotel == null)
                {
                    return NotFound($" not found with ID: {model.Id}");
                }

                hotel.Name = model.Name;
                hotel.Email = model.Email;
                hotel.PhoneNo = model.PhoneNo;

                _context.SaveChanges();

                return Ok("Hotel updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")] // delete by id
        public IActionResult Delete(Guid id)
        {
            try
            {
                var employee = _context.Employee.Find(id);
                if (employee == null)
                {
                    return NotFound($"Employee not found with ID: {id}");
                }

                _context.Employee.Remove(employee);
                _context.SaveChanges();

                return Ok("Employee deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
