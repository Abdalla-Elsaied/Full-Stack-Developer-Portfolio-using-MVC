using Microsoft.EntityFrameworkCore;
using MVC_EX_1.Models;
using Portfolio.Models;

namespace MVC_EX_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Developer> Dev { get; set; }
        public DbSet<Client> Client { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
