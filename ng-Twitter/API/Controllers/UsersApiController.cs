using Microsoft.AspNetCore.Mvc;
using Models.Core.Features.Users;
using ng_Twitter.Services;

[Route("api/Users")]
public class UsersApiController : Controller
{
    private readonly IUserService _userService;
    
    
    public UsersApiController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("GetUserByEmail/{email}")]
    public User GetUserByEmail(string email)
    {
        return _userService.GetUserByEmail(email);
    }

    [HttpGet("GetUserById/{userId}")]
    public User GetUserById(int userId)
    {
        return _userService.GetUserById(userId);
    }

    [HttpGet("GetAllUsers")]
    public IActionResult GetAllUsers()
    {
        var result = _userService.GetAllUsers();
        return Ok(result);
    }

    [HttpPut("UpdatePassword/{id}")]
    public void UpdatePasswordByUserId(int id, [FromBody] User user)
    {
         _userService.UpdatePasswordByUserId(id, user.Password);
    }

    [HttpPost("Login")]
    public int Login([FromBody] User currentUser)
    {
        var user = _userService.Login(currentUser.Email, currentUser.Password);

        return (user == null) ? 0 : user.Id;
    }
         
    
}
