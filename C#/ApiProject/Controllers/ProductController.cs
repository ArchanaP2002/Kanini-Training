 
using Microsoft.AspNetCore.Mvc;
using ApiProject.DataAccess;
using ApiProject.Model_s;
using System;
using System.Linq;
 

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase// inherit from ControllerBase
    {
        private readonly ProductContext _context;

        //takes a ProductContext parameter and assigns it to the _context field.

        public ProductController(ProductContext context)
        {
            _context = context;
        }

        [HttpGet]// Read from Data base 
        public IActionResult Get()
        {
            try
            {
                var products = _context.Products.ToList();//property to get all orders as a list 
                if (products.Count == 0)
                {
                    return NotFound("No products available.");
                }
                return Ok(products);
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
                var product = _context.Products.Find(id);
                if (product == null)
                {
                    return NotFound($"Product not found with ID: {id}");
                }
                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]// Creating
        public IActionResult Post(Product model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
                return Ok("Product created successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut] // Update by id
        public IActionResult Put(Product model)
        {
            try
            {
                if (model == null || model.Id == 0)
                {
                    return BadRequest("Invalid data or ID.");
                }

                var product = _context.Products.Find(model.Id);
                if (product == null)
                {
                    return NotFound($"Product not found with ID: {model.Id}");
                }

                product.ProductName = model.ProductName;
                product.Price = model.Price;
                product.City = model.City;

                _context.SaveChanges();

                return Ok("Product updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")] // Delete by id
        public IActionResult Delete(int id)
        {
            try
            {
                var product = _context.Products.Find(id);
                if (product == null)
                {
                    return NotFound($"Product not found with ID: {id}");
                }

                _context.Products.Remove(product);
                _context.SaveChanges();

                return Ok("Product deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

