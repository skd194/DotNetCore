using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}