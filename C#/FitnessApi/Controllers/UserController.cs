﻿using FitnessApi.model_s;
 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly FitnessContext _context;

        public UserController(FitnessContext context)
        {
            _context = context;
        }

        [HttpGet] // Read from Data base 
        public IActionResult Get()
        {
            try
            {
                var user = _context.Users.ToList();//property to get all list 
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

        [HttpGet("{id}")]// ready by id 
        public IActionResult Get(int id)
        {
            try
            {
                var user = _context.Users.Find(id);
                if (user == null)
                {
                    return NotFound($"Not found with ID: {id}");
                }
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost] // Creating
        public IActionResult Post(Users model)
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
        public IActionResult Put(Users model)
        {
            try
            {
                if (model == null || model.userId == 0)
                {
                    return BadRequest("Invalid data or ID.");
                }
 
                _context.SaveChanges();

                return Ok(" updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}

