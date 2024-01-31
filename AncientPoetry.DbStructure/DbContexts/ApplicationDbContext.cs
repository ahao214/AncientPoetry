
using AncientPoetry.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

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
        public DbSet<FamoutPhrase> FamoutPhrases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
