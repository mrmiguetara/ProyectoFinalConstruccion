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

        public DbSet<Exam> Exams { get; set; }
    }

}