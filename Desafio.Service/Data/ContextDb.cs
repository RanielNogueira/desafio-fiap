using Desafio.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Service.Data
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions builder):base(builder) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subscribe>().HasKey(c => new { c.Id });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Subscribe> Subscribe { get; set; }
    }
}
