using figmaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using figmaApi.Repositories;

namespace figmaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _addressRepository;

        public AddressController(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var addresses = _addressRepository.GetAllAddresses();
                if (!addresses.Any())
                {
                    return NotFound("No addresses available.");
                }
                return Ok(addresses);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{id}")]
        public IActionResult Get(int addressInformationId)
        {
            try
            {
                var address = _addressRepository.GetAddressById(addressInformationId);
                if (address == null)
                {
                    return NotFound($"Address not found with ID: {addressInformationId}");
                }
                return Ok(address);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(AddressInformationTable model)
        {
            try
            {
                _addressRepository.AddAddress(model);
                return Ok("Address created successfully.");
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
    }
}
