using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class DataContext : DbContext
  {
    public DbSet<Make> Make { get; set; }
    public DbSet<VehicleModel> VehicleModel { get; set; }
    public DbSet<AppUser> Users { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DataContext(DbContextOptions options) : base(options)
    {
    }
  }
}