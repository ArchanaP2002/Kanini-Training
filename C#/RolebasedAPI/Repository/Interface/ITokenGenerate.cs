using RolebasedAPI.Models.DTO;

namespace RolebasedAPI.Repository.Interface
{
    public interface ITokenGenerate
    {
        public string GenerateToken(UserDTO user);
    }
}
