using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Persistence
{
    public class DbContextFactory : IDesignTimeDbContextFactory<GeneratorDbContext> 
    {
        public GeneratorDbContext CreateDbContext(string[] args)
        {

            return GetContext();

        }

        public GeneratorDbContext GetContext()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "../Api/appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var configuration = configurationBuilder.Build();
            var connectionString = configuration.GetConnectionString("OzunaConnection");
            var builder = new DbContextOptionsBuilder<GeneratorDbContext>();
            builder.UseMySql(connectionString);
            return new GeneratorDbContext(builder.Options); 
        }

        public GeneratorDbContext GetTestContext()
        {
            var builder = new DbContextOptionsBuilder<GeneratorDbContext>();
            builder.UseInMemoryDatabase();
            return new GeneratorDbContext(builder.Options); 
        }
        
        public GeneratorDbContext GetContextMySqlConnection(string connectionString)
        {
            var builder = new DbContextOptionsBuilder<GeneratorDbContext>();
            builder.UseMySql(connectionString);
            return new GeneratorDbContext(builder.Options); 
        }
    }
}