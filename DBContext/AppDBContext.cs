using api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.DBContext
{
    public class AppDBContext : IdentityDbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Lista> Listas { get; set; }  
        public DbSet<TarefaLista> Tarefas { get; set; }      
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Lista>().HasKey(m => m.ID);
            base.OnModelCreating(builder);
        }
    }
}