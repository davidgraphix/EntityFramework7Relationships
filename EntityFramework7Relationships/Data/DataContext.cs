using Microsoft.EntityFrameworkCore;

namespace EntityFramework7Relationships.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }
    }
}
