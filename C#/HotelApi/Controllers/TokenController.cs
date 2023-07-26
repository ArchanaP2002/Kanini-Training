using HotelApi.data;
using HotelApi.model_s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HotelApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase 
    {

        public IConfiguration _configuration; // interface that provides access to configuration settings

        private readonly HotelContext _context; //inherits from DbContext and represents the database context

        public TokenController(IConfiguration config, HotelContext context)
        {
            _configuration = config;  
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Users _userData)
        {
            if (_userData != null && _userData.UserEmail != null && _userData.Password != null) // it checks the userdata is not null 
            {
                // GetUser() method to find a user object that matches the given UserEmail and Password properties
                var user = await GetUser(_userData.UserEmail, _userData.Password);

                if (user != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                         new Claim("UserId", user.UserId.ToString()),
                         new Claim("Email", user.UserEmail),
                        new Claim("Password",user.Password)

                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));//It creates a SymmetricSecurityKey

                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    //It creates a SigningCredentials using SymmetricSecurityKey 
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],//It creates a JwtSecurityToken object
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(10), // expire time is 10mins 
                        signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<Users> GetUser(string email, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserEmail == email && u.Password == password);
        }
    }
}

