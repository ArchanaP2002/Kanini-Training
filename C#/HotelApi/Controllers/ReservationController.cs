using HotelApi.data;
using HotelApi.model_s;
using HotelApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly HotelContext _context;  //inherits from DbContext and represents the database context

        public ReservationController(HotelContext context)
        {
            _context = context; // to access the Reservation property
        }

        [HttpGet] // Read from Data base 
        public IActionResult Get()
        {
            try
            {
                var reservations = _context.Reservations.ToList();//property to get all list 
                if (reservations.Count == 0)
                {
                    return NotFound("Not available.");
                }
                return Ok(reservations);
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
                var reservation = _context.Reservations.Find(id);
                if (reservation == null)
                {
                    return NotFound($"Not found with ID: {id}");
                }
                return Ok(reservation);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost] // Creating
        public IActionResult Post(Reservation model)
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
        public IActionResult Put(Reservation model)
        {
            try
            {
                if (model == null || model.ReservationId == 0)
                {
                    return BadRequest("Invalid data or ID.");
                }

                var reservation = _context.Reservations.Find(model.ReservationId);
                if (reservation == null)
                {
                    return NotFound($"Hotel not found with ID: {model.ReservationId}");
                }

                reservation.CustomerName = model.CustomerName;

                _context.SaveChanges();

                return Ok(" updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")] //delete by id
        public IActionResult Delete(int Reservationid)
        {
            try
            {
                var reservation = _context.Reservations.Find(Reservationid);
                if (reservation == null)
                {
                    return NotFound($"Hotel not found with ID: {Reservationid}");
                }

                _context.Reservations.Remove(reservation);
                _context.SaveChanges();

                return Ok("deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}

