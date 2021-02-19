using CompanyStatistics.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyStatistics.Data
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Visit> Visits { get; set; }

        public CompanyDbContext(DbContextOptions<CompanyDbContext> options):
            base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
