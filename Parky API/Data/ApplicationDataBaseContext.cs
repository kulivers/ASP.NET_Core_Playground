using Microsoft.EntityFrameworkCore;
using Parky_API.Models;

namespace Parky_API.Data
{
    public class ApplicationDataBaseContext : DbContext
    {
        public ApplicationDataBaseContext(DbContextOptions<ApplicationDataBaseContext> options) : base(options)
        {
            
        }

        public DbSet<NationalPark> NationalParks { get; set; }
    }
}