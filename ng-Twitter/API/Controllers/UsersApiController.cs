using Microsoft.AspNetCore.Mvc;
using Models.Core.Features.Users;
using ng_Twitter.Services;

[Route("api/Users")]
public class UsersApiController : Controller
{
    private readonly IUserService _userservice;

    public UsersApiController(IUserService userservice)
    {
        _userservice = userservice;
    }

    [HttpGet("GetUserByEmail")]
    public User GetUserByEmail(User user)
    {
        return _userservice.GetUserByEmail(user.Email);
    }

    [HttpGet("GetAllUsers")]
    public IActionResult GetAllUsers()
    {
        var result = _userservice.GetAllUsers();
        return Ok(result);
    }
}
