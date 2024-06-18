using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Database;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<AppUser> AppUser { get; set;}
}
