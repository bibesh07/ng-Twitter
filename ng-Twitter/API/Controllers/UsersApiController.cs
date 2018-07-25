using Microsoft.AspNetCore.Mvc;
using Models.Core.Features.Users;
using ng_Twitter.Services;
using Newtonsoft.Json;

[Route("api/Users")]
public class UsersApiController : Controller
{
    private readonly IUserService _userService;

    private readonly ITweetService _tweetService;
    
    public UsersApiController(IUserService userService, ITweetService tweetService)
    {
        _userService = userService;
        _tweetService = tweetService;
    }

    [HttpGet("GetUserByEmail/{email}")]
    public IActionResult GetUserByEmail(string email)
    {
        return Ok(_userService.GetUserByEmail(email));
    }

    [HttpGet("GetUserById/{userId}")]
    public IActionResult GetUserById(int userId)
    {
        var userInfo = _userService.GetUserById(userId);
        //int userTweetCount = _tweetService.GetUserTweetNumber(userId);
        
        //return Json(userInfo);
        return Ok(userInfo);
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
