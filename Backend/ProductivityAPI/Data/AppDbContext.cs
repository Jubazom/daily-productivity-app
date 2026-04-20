using Microsoft.EntityFrameworkCore;
using ProductivityAPI.Models;

namespace ProductivityAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}