
using Microsoft.AspNetCore.Mvc;
using ApiProject.DataAccess;
using System;
using System.Linq;
using ApiProject.Model_s;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase // inherit from ControllerBase
    {
        private readonly ProductContext _context;

        //takes a ProductContext parameter and assigns it to the _context field.

        public CategoryController(ProductContext context)
        {
            _context = context;
        }

        [HttpGet] // Read from Data base 
        public IActionResult Get()
        {
            try
            {
                var categories = _context.Categories.ToList();//property to get all orders as a list 
                if (categories.Count == 0)
                {
                    return NotFound("No categories available.");
                }
                return Ok(categories);
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
                var category = _context.Categories.Find(id);
                if (category == null)
                {
                    return NotFound($"Category not found with ID: {id}");
                }
                return Ok(category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    

        [HttpPost] // Creating
        public IActionResult Post(Category model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
                return Ok("Category created successfully.");
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occurred while saving the entity changes.";
                if (ex.InnerException != null)
                {
                    errorMessage += " Inner Exception: " + ex.InnerException.Message;
                }
                return BadRequest(errorMessage);
            }
        }

        [HttpPut] //Update
        public IActionResult Put(Category model)
        {
            try
            {
                if (model == null || model.Id == 0)
                {
                    return BadRequest("Invalid data or ID.");
                }

                var category = _context.Categories.Find(model.Id);
                if (category == null)
                {
                    return NotFound($"Category not found with ID: {model.Id}");
                }

                category.CategoryName = model.CategoryName;

                _context.SaveChanges();

                return Ok("Category updated successfully.");
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
                var category = _context.Categories.Find(id);
                if (category == null)
                {
                    return NotFound($"Category not found with ID: {id}");
                }

                _context.Categories.Remove(category);
                _context.SaveChanges();

                return Ok("Category deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

