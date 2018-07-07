using ClassLibray.Core.Features.Tweets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Models.Core.Features.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

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
        if (optionsBuilder.IsConfigured) return;
        
        // Build Configuration:
        var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .Build();

        // Check if configuration is good:
        if (string.IsNullOrEmpty(configuration.GetConnectionString("DefaultConnection")))
            throw new Exception("Connection string (default) not set. Please set them on Repository or Web Project.");

        Console.WriteLine("Using Connection string: {0}",configuration.GetConnectionString("(default)"));
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        
    }
}
