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

        // GET api/values
        [HttpGet("GetAllTweets")]
        public IEnumerable<Tweet> GetAllTweets()
        {
            return _tweetService.GetAllTweets();
        }
    }
}
