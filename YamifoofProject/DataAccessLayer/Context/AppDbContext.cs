using Microsoft.EntityFrameworkCore;
using YamifoofProject.DataAccessLayer.Entities;

namespace YamifoofProject.DataAccessLayer.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Footer> Footers { get; set; }
}

