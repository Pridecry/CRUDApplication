using CRUDApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDApplication.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
