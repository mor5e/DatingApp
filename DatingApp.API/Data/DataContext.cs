using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Design;
// using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> Values { get; set; }
    }


// public class DataContext : IDesignTimeDbContextFactory<DataContext>
//     {
//         public DataContext CreateDbContext(string[] args)
//         {
//             var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
//             optionsBuilder.UseSqlite("Data Source=blog.db");

//             return new DataContext(optionsBuilder.Options);
//         }
//     }
}

