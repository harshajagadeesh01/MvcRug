using Microsoft.EntityFrameworkCore;
using MvcRug.Models;

namespace MvcRug.Data
{
    public class MvcRugContext : DbContext
    {
        public MvcRugContext(DbContextOptions<MvcRugContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}