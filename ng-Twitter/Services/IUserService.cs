using Models.Core.Features.Users;
using System.Collections.Generic;

namespace ng_Twitter.Services
{
    public interface IUserService
    {
        User GetUserByEmail(string email);

        User GetUserById(int id);
        
        ICollection<User> GetAllUsers();

        void UpdatePasswordByUserId(int id, string password);
    }
}
