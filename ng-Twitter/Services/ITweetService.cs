using ClassLibray.Core.Features.Tweets;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface ITweetService
{
    IEnumerable<Tweet> GetAllTweets();

    IEnumerable<Tweet> GetTweetsByUserId(int Id);

    void AddTweet(Tweet tweet);

    int GetUserTweetNumber(int id);

    void DeleteTweet(int id);

    Tweet GetTweetById(int id);
}
