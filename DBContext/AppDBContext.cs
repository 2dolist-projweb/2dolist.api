using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Lista> Listas { get; set; }        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Lista>().HasKey(m => m.ID);
            base.OnModelCreating(builder);
        }
    }
}