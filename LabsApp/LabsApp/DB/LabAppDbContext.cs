using LabsApp.Models;
using Microsoft.EntityFrameworkCore;


namespace LabsApp.Web.Database
{
    public class LabsAppDbContext : DbContext
    {
        public LabsAppDbContext(DbContextOptions options)
        : base(options)
        {
        }
        public DbSet<ItemEntity> Items { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // fluent configuration ...
        }
    }
}
