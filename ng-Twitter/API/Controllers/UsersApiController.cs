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

    [HttpGet("GetUserByEmail/{email}")]
    public User GetUserByEmail(string email)
    {
        return _userservice.GetUserByEmail(email);
    }

    [HttpGet("GetUserById/{userId}")]
    public User GetUserById(int userId)
    {
        return _userservice.GetUserById(userId);
    }

    [HttpGet("GetAllUsers")]
    public IActionResult GetAllUsers()
    {
        var result = _userservice.GetAllUsers();
        return Ok(result);
    }

    [HttpPut("UpdatePassword/{id}")]
    public void UpdatePasswordByUserId(int id, [FromBody] User user)
    {
         _userservice.UpdatePasswordByUserId(id, user.Password);
    }
    
}
