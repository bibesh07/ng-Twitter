using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibray.Core.Features.Tweets;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models.Core.Features.Users;

namespace ng_Twitter.Controllers
{
    [Route("api/tweets")]
    public class TweetApiController : Controller
    {
        private readonly ITweetService _tweetService;

        public TweetApiController(ITweetService tweetService)
        {
            _tweetService = tweetService;
        }

        [HttpGet("GetAllTweets")]
        public IActionResult GetAllTweets()
        {
            var tweets = _tweetService.GetAllTweets();
            return Ok(tweets.Reverse());
        }

        [HttpGet("GetTweetsByUserId/{id}")]
        public IActionResult GetTweetsByUserId(int id)
        {
            var tweets =  _tweetService.GetTweetsByUserId(id);
            return Ok(tweets);
        }

        [HttpPost("AddTweet")]
        public IActionResult AddTweet([FromBody] Tweet tweet)
        {
            if (tweet.Content.Trim() != "")
            {
                _tweetService.AddTweet(tweet);
            }
            //return success or error message
            return Ok();
        }
        
        [HttpDelete("DeleteTweet/{id}/{loggedInUserId}")]
        public IActionResult DeleteTweet(int id, int loggedInUserId)
        {
            var tweet = _tweetService.GetTweetById(id);
            var belongsTo = tweet.UserId;

            if (belongsTo == loggedInUserId)
            {
                _tweetService.DeleteTweet(id);
            }
            //return success or error message
            return Ok(id);
        }
        
        [HttpGet("GetUserTweetCount/{userId}")]
        public IActionResult GetUserTweetCount(int userId)
        {
            return Ok(_tweetService.GetUserTweetNumber(userId));
        }
    }
}
