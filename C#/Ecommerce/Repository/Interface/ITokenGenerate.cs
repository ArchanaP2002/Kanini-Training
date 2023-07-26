using Ecommerce.Models.DTO;

namespace Ecommerce.Repository.Interface
{
    public interface ITokenGenerate
    {
        public string GenerateToken(UserDTO user);
    }
}
