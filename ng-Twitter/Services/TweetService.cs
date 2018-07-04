using ClassLibray.Core.Features.Tweets;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


public class TweetService: ITweetService
{
    private readonly DataContext _dataContext;

    public TweetService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public IEnumerable<Tweet> GetAllTweets() => _dataContext.Tweets.ToList();

    public IEnumerable<Tweet> GetTweetsByUserId(int Id) => _dataContext.Tweets.Where(t => t.UserId == Id).Include(x => x.User);

    public void AddTweet(Tweet tweet)
    {
        _dataContext.Tweets.Add(tweet);
        _dataContext.SaveChanges();
    }
}
