using Microsoft.EntityFrameworkCore;
using MyDotNetHub.Models; // replace with your actual model namespace

namespace MyDotNetHub.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } // example table
    }
}