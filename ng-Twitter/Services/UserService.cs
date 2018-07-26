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

        public User GetUserByEmail(string Email) => _context.Users.FirstOrDefault(m => m.Email == Email);

        public User GetUserById(int id) => _context.Users.Include(t => t.Tweets).First(i => i.Id == id);

        public IEnumerable<User> GetAllUsers() => _context.Users.Include(t => t.Tweets).ToList();
        
        public void UpdatePasswordByUserId(int id, string password)
        {
            var user = _context.Users.Find(id);
            user.Password = password;
            _context.Update(user);
            _context.SaveChanges();
        }
                
        public User Login(string email, string password)
        {
            var user = this.GetUserByEmail(email);

            if (user == null || user.Password != password)
            {
                return null;
            }

            return user;
            
        }

        public void Register(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }
    }
}
