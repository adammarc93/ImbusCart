using Microsoft.EntityFrameworkCore;

using ImbusCart.API.Models;

namespace ImbusCart.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}