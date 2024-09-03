using authentication_authorization_scratch_.Models;
using Microsoft.EntityFrameworkCore;

namespace authentication_authorization_scratch_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
