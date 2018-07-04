using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibray.Core.Features.Tweets;
using Microsoft.AspNetCore.Mvc;

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
        public IEnumerable<Tweet> GetAllTweets()
        {
            return _tweetService.GetAllTweets();
        }

        [HttpGet("GetTweetsByUserId/{id}")]
        public IEnumerable<Tweet> GetTweetsByUserId(int id)
        {
            return _tweetService.GetTweetsByUserId(id);
        }

        [HttpPost("AddTweet")]
        public IActionResult AddTweet([FromBody] Tweet tweet)
        {
            _tweetService.AddTweet(tweet);
            return Ok();
        }

    }
}
