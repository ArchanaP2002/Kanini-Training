using HotelApi.data;
using HotelApi.model_s;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly HotelContext _context;  //inherits from DbContext and represents the database context

        public HotelController(HotelContext context)
        {
            _context = context; // to access the hotel property
        } 

        [HttpGet] // Read from Data base 
        public IActionResult Get()
        {
            try
            {
                var hotel = _context.Hotels.ToList();//property to get all list 
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
        public IActionResult Get(int id)
        {
            try
            {
                var hotel = _context.Hotels.Find(id);
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
        public IActionResult Post(Hotel model)
        {
            try
            {
                _context.Add(model); // insert into db
                _context.SaveChanges(); // commit 
                return Ok("Hotel created successfully.");
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
        public IActionResult Put(Hotel model)
        {
            try
            {
                if (model == null || model.HotelId == 0)
                {
                    return BadRequest("Invalid data or ID.");
                }

                var hotel = _context.Hotels.Find(model.HotelId);
                if (hotel == null)
                {
                    return NotFound($"Hotel not found with ID: {model.HotelId}");
                }

                hotel.Name = model.Name;

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
                var hotel = _context.Hotels.Find(id);
                if (hotel == null)
                {
                    return NotFound($"Hotel not found with ID: {id}");
                }

                _context.Hotels.Remove(hotel);
                _context.SaveChanges();

                return Ok("Hotel deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("filter")]
        public ActionResult<IEnumerable<Hotel>> FilterHotels(string location)
        {
            
 

            // Apply the filter criteria
            var hotels = _context.Hotels.Where(h => h.Location == location );

            // Return the filtered hotels
            return hotels.ToList();

        }



    }


}



