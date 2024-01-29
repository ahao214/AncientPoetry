
using AncientPoetry.Entities;
using Microsoft.EntityFrameworkCore;

namespace AncientPoetry.DbStructure.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Dynasty> Dynasties { get; set; }
        public DbSet<Poet> Poets { get; set; }
        public DbSet<Poem> Poems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
