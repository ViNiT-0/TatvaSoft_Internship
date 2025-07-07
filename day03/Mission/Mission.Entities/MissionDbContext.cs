using Microsoft.EntityFrameworkCore;
using Mission.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Entities
{
    public class MissionDbContext(DbContextOptions<MissionDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                FirstName = "Admin",
                LastName = "Tatva",
                EmailAddress = "Admin@gmail.com",
                Password = "Admin@123",
                PhoneNumber = "123-456-7890",
                UserType = "Admin",
                UserImage = null

            });
            base.OnModelCreating(modelBuilder);
        }
    }

}
