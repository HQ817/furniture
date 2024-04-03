using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Internet.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Models.Supplier> Suppliers { get; set; }


        public DbSet<Models.Product> Furnitures { get; set; }

        public DbSet<Models.Contact> Contacts { get; set; }

        private readonly IConfiguration _configuration;
        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
