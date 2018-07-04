using ClassLibray.Core.Features.Tweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class TweetService: ITweetService
{
    private readonly DataContext _dataContext;

    public TweetService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public IEnumerable<Tweet> GetAllTweets() => _dataContext.Tweets.ToList();
}
