using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Entities.Factory
{
    public class MissionDbContextFactory : IDesignTimeDbContextFactory<MissionDbContext>
    {
        public MissionDbContext CreateDbContext(string[] args)
        {
            // Set base path to the API project's directory
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Mission.Api"))
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<MissionDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString); // Or UseNpgsql/UseSqlite/etc. based on your DB

            return new MissionDbContext(optionsBuilder.Options);
        }
    }
}
