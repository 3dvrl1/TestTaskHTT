using HTTTest.Infrastructure.Dto;
using Microsoft.EntityFrameworkCore;

namespace HTTTest.Infrastructure.Context;

public class LocalDataBaseContext : DbContext
{
    public LocalDataBaseContext()
    {
        
    }
    
    // <summary>
    /// Установка культуры.
    /// </summary>
    /// <param name="options"></param>
    public LocalDataBaseContext(DbContextOptions<LocalDataBaseContext> options)
        : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }
    public DbSet<Item> Items { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    
}