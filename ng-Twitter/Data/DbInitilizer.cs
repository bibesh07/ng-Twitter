using ClassLibray.Core.Features.Tweets;
using Models.Core.Features.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class DbInitilizer
{
    public static void SeedData(DataContext dataContext)
    {
        _SeedUsers(dataContext);
        _SeedTweets(dataContext);
    }

    private static void _SeedUsers(DataContext dataContext)
    {
        var user = dataContext.Set<User>();
        if (user.Any())
        {
            return;
        }

        user.Add(new User
        {
            Name = "Amrit Subedi",
            Email = "joker@subedi.com",
            Bio = "I am a Joker man",
            Password = "YAMRIT",
            PhoneNumber = "1234567889",
            UserName = "SUBEDI18",
            Website = "github.com/yamrit",
            DateJoined = new DateTime(),
            BirthDate = new DateTime()
        });
        dataContext.SaveChanges();
    }

    private static void _SeedTweets(DataContext dataContext)
    {
        var tweet = dataContext.Set<Tweet>();
        if(tweet.Any())
        {
            return;
        }

        tweet.Add(new Tweet
        {
            Content = "This is a new tweet",
            UserId = 1,
        });
        dataContext.SaveChanges();
    }
}