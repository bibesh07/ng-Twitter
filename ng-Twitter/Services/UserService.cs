﻿using Models.Core.Features.Users;
using System.Collections.Generic;
using System.Linq;

namespace ng_Twitter.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public User GetUserByEmail(string Email) => _context.Users.First(m => m.Email == Email);

        public IEnumerable<User> GetAllUsers() => _context.Users.ToList();
    }
}
