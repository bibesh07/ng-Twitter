using Models.Core.Features.Users;
using System.Collections.Generic;

namespace ng_Twitter.Services
{
    public interface IUserService
    {
        User GetUserByEmail(string email);

<<<<<<< HEAD
        IEnumerable<User> GetAllUsers();

        User GetUserById(int id);
        
=======
        User GetUserById(int id);
        
        ICollection<User> GetAllUsers();

>>>>>>> amrit
        void UpdatePasswordByUserId(int id, string password);
    }
}
