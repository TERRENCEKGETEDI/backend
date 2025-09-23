    using System;

    using Microsoft.EntityFrameworkCore;
    using backend;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // This tells EF Core that you have a table called "News" 
        // that maps to your NewsArticle class.
        public DbSet<NewsArticle> News { get; set; }
    }
