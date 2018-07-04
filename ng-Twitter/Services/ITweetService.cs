using ClassLibray.Core.Features.Tweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface ITweetService
{
    IEnumerable<Tweet> GetAllTweets();
}
