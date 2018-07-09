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

<<<<<<< HEAD
        public IEnumerable<User> GetAllUsers() => _context.Users.ToList();
=======
        public User GetUserById(int id) => _context.Users.Include(t => t.Tweets).First(i => i.Id == id);

        public ICollection<User> GetAllUsers() => _context.Users.Include(t => t.Tweets).ToList();
        
        public void UpdatePasswordByUserId(int id, string password)
        {
            var user = _context.Users.Find(id);
            user.Password = password;
            _context.Update(user);
            _context.SaveChanges();
        }
        
>>>>>>> a92bf262c52db305e54a731cac9e4a32e6d94da7
    }
}
