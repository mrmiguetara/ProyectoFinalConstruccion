using System.Configuration;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class GeneratorDbContext : DbContext
    {
        

        public GeneratorDbContext(DbContextOptions<GeneratorDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<Section> Sections { get; set; }
        
        public DbSet<ApplicationUser> Users { get; set; }
    }

}