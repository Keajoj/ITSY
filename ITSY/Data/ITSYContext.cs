using Microsoft.EntityFrameworkCore;
using ITSY.Models;

namespace ITSY.Data
{
    public class ITSYContext : DbContext
    {
        public ITSYContext (DbContextOptions<ITSYContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Ticket { get; set; }
    }
}