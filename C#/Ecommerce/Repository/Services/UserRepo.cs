using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Repository.Interface;
using System.Diagnostics;

namespace Ecommerce.Repository.Services
{
    public class UserRepo : IbaseRepo<string, User>
    {
        private readonly EcommerceContext _context;

        public UserRepo(EcommerceContext context)
        {
            _context = context;
        }
        public User Add(User item)
        {
            try
            {
                _context.Users.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                Debug.WriteLine(item);
            }
            return null;
        }

        public User Get(string key)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == key);
            return user;
        }


    }
}
