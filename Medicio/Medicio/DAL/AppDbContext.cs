using Medicio.Models;
using Microsoft.EntityFrameworkCore;

namespace Medicio.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }
        public DbSet<Doctors> Doctor { get; set; }
    }
}
