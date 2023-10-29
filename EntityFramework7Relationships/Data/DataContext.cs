using EntityFramework7Relationships.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework7Relationships.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Character> Characters { get; set; }
        public DbSet<BackPack> BackPacks { get; set; }

    }
}
