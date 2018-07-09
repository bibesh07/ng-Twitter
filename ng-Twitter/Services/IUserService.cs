using Models.Core.Features.Users;
using System.Collections.Generic;

namespace ng_Twitter.Services
{
    public interface IUserService
    {
        User GetUserByEmail(string email);
<<<<<<< HEAD
        IEnumerable<User> GetAllUsers();
=======

        User GetUserById(int id);
        
        ICollection<User> GetAllUsers();

        void UpdatePasswordByUserId(int id, string password);
>>>>>>> a92bf262c52db305e54a731cac9e4a32e6d94da7
    }
}
