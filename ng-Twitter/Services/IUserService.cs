using Models.Core.Features.Users;
using System.Collections.Generic;

namespace ng_Twitter.Services
{
    public interface IUserService
    {
        User GetUserByEmail(string email);

        IEnumerable<User> GetAllUsers();

        User GetUserById(int id);
        
        void UpdatePasswordByUserId(int id, string password);
    }
}
