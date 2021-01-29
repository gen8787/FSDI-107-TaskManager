using Microsoft.EntityFrameworkCore;

namespace TaskManager.Models
{
    public class DataContext : DbContext //<~~ Add : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Task> Tasks { get; set; }
    }
}

// Migrations
// dotnet ef migrations add DbSetup
// dotnet ef database update