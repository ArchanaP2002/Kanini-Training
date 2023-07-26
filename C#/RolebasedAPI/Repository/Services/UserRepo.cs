﻿using RolebasedAPI.Data;
using RolebasedAPI.Models;
using RolebasedAPI.Repository.Interface;
using System.Diagnostics;

namespace RolebasedAPI.Repository.Services
{
    public class UserRepo : IBaseRepo<string, User>
    {
        private readonly RoleBasedAuthorizationDbContext _context;

        public UserRepo(RoleBasedAuthorizationDbContext context)
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
            var user = _context.Users.FirstOrDefault(u => u.Id == key);
            return user;
        }


    }
}
