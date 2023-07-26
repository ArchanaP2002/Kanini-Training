using ApiProject.DataAccess;
using ApiProject.Model_s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase // inherit from ControllerBase
    {
        private readonly ProductContext _context;

        //takes a ProductContext parameter and assigns it to the _context field.

        public OrderController(ProductContext context)
        {
            _context = context;
        }

        [HttpGet] // Read from Data base 
        public IActionResult Get()
        {
            try
            {
                var orders = _context.Orders.ToList(); //property to get all orders as a list 
                if (orders.Count == 0)
                {
                    return NotFound("No orders available.");
                }
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]  // ready by id 
        public IActionResult Get(int id)
        {
            try
            {
                var order = _context.Orders.Find(id);
                if (order == null)
                {
                    return NotFound($"Order not found with ID: {id}");
                }
                return Ok(order);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        

        [HttpPost] // creating 
        public IActionResult Post(Order model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
                return Ok("Order created successfully.");
            }
            catch (DbUpdateException ex)
            {
                // Log or output the inner exception details
                var innerExceptionMessage = ex.InnerException?.Message;
                return BadRequest(  innerExceptionMessage);
            }

            catch (Exception ex)
            {
                // Handle general exception
                return BadRequest("An error occurred. " + ex.Message);
            }
        }

 
        [HttpPut] // update
        public IActionResult Put(Order model)
        {
            try
            {
                if (model == null || model.Id == 0)
                {
                    return BadRequest("Invalid data or ID.");
                }

                var order = _context.Orders.Find(model.Id);
                if (order == null)
                {
                    return NotFound($"Order not found with ID: {model.Id}");
                }

                // Validate the model
                var validationResults = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(model, new ValidationContext(model), validationResults, true);
                if (!isValid)
                {
                    var errorMessages = validationResults.Select(vr => vr.ErrorMessage);
                    return BadRequest(string.Join("; ", errorMessages));
                }

                order.ProductId = model.ProductId;
                order.Quantity = model.Quantity;
                order.OrderDate = model.OrderDate;

                _context.SaveChanges();

                return Ok("Order updated successfully.");
            }
            catch (DbUpdateException ex)
            {
                // Log or output the inner exception details
                var innerExceptionMessage = ex.InnerException?.Message;
                return BadRequest(  innerExceptionMessage);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var order = _context.Orders.Find(id);
                if (order == null)
                {
                    return NotFound($"Order not found with ID: {id}");
                }

                _context.Orders.Remove(order);
                _context.SaveChanges();

                return Ok("Order deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

