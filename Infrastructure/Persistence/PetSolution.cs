using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Persistence
{
    public class PetSolution : IDesignTimeDbContextFactory<PetContext>
    {
        public PetContext CreateDbContext(string[] args)
        {
             IConfiguration configuration= new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) 
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionstring= configuration.GetConnectionString("PetDBConnection");
            var optionsBuilder = new DbContextOptionsBuilder<PetContext>();
             optionsBuilder.UseSqlServer(connectionstring);

            return new PetContext(optionsBuilder.Options);
        }
    }
}