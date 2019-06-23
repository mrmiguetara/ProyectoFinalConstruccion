using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class GeneratorDbContext : DbContext
    {

        public GeneratorDbContext(DbContextOptions<GeneratorDbContext> options) : base(options)
        { }
        
    }

