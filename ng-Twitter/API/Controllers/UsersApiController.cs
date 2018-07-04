using Microsoft.AspNetCore.Mvc;
using Models.Core.Features.Users;
using ng_Twitter.Services;
using System.Collections.Generic;

[Route("api/Users")]
public class UsersApiController : Controller
{
    private readonly IUserService _userservice;

    public UsersApiController(IUserService userservice)
    {
        _userservice = userservice;
    }

    [HttpGet("GetUserByEmail")]
    public User GetUserByEmail([FromBody] User user)
    {
        return _userservice.GetUserByEmail(user.Email);
    }

    [HttpGet("GetAllUsers")]
    public ICollection<User> GetAllUsers()
    {
        return _userservice.GetAllUsers();
    }
}
