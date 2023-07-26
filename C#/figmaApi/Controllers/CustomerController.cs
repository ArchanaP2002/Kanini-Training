using figmaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace figmaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var customers = _customerRepository.GetAllCustomers();
                if (customers.Count == 0)
                {
                    return NotFound("No customers available.");
                }
                return Ok(customers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var customer = _customerRepository.GetCustomerById(id);
                if (customer == null)
                {
                    return NotFound($"Customer not found with ID: {id}");
                }
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(CustomerTable model)
        {
            try
            {
                _customerRepository.AddCustomer(model);
                return Ok("Customer created successfully.");
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

        [HttpPut]
        public IActionResult Put(CustomerTable model)
        {
            try
            {
                if (model == null || model.CustomerId == 0)
                {
                    return BadRequest("Invalid data or ID.");
                }

                var customer = _customerRepository.GetCustomerById(model.CustomerId);
                if (customer == null)
                {
                    return NotFound($"Customer not found with ID: {model.CustomerId}");
                }

                customer.Name = model.Name;
                customer.EmailId = model.EmailId;
                customer.Password = model.Password;

                _customerRepository.UpdateCustomer(customer);

                return Ok("Customer updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
