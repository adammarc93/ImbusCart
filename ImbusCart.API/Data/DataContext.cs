using Microsoft.EntityFrameworkCore;

namespace ImbusCart.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}