namespace RepoLayer;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RepoLayer.Models;

public class DataContext: DbContext {

    public DbSet<User> Users { get; set; }

    protected readonly IConfiguration _configuration;

    public DataContext(IConfiguration configuration) {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) {
        options.UseNpgsql(_configuration.GetConnectionString("DbContext"));
        // options.UseNpgsql(_configuration.GetConnectionString("DbContext"), b => b.MigrationsAssembly("StarwarAPI"));
        // options.UseNpgsql("Username=postgres;Password=postgres;Host=localhost;Database=postgres");
    }

}
