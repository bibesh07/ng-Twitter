using Models.Core.Features.Users;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ng_Twitter.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public User GetUserByEmail(string Email) => _context.Users.Include(t => t.Tweets).First(m => m.Email == Email);

        public ICollection<User> GetAllUsers() => _context.Users.Include(t => t.Tweets).ToList();
    }
}
