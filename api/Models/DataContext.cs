using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<WorkGroup> WorkGroups { get; set; }
    }
}
