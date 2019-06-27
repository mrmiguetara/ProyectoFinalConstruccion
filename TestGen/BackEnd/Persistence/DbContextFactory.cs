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

            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "../Api/appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var configuration = configurationBuilder.Build();
            var connectionString = configuration.GetConnectionString("OzunaConnection");
            var builder = new DbContextOptionsBuilder<GeneratorDbContext>();
            builder.UseMySQL(connectionString);
            return new GeneratorDbContext(builder.Options); 
        } 
    }
}