using ClassLibray.Core.Features.Tweets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Models.Core.Features.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(IDbContextOptions options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Tweet> Tweets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TwitterClone;Trusted_Connection=True");
        }
    }
}
