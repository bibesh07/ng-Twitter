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

    public int GetUserTweetNumber(int id) => _dataContext.Tweets.Count(u => u.UserId == id);
    
    public IEnumerable<Tweet> GetAllTweets() => _dataContext.Tweets.Include("User").ToList();

    public IEnumerable<Tweet> GetTweetsByUserId(int Id) => _dataContext.Tweets.Where(t => t.UserId == Id);

    public void AddTweet(Tweet tweet)
    {
        _dataContext.Tweets.Add(tweet);
        _dataContext.SaveChanges();
    }

    public void DeleteTweet(int id)
    {
        var tweet = _dataContext.Tweets.Where(u => u.Id == id).SingleOrDefault();
        if (tweet != null)
        {
            _dataContext.Tweets.Remove(tweet);
            _dataContext.SaveChanges();
        }
    }
}
