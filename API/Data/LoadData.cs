using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class LoadData
  {
    public static async Task LoadManufacturers(DataContext context)
    {
      if (await context.Make.AnyAsync()) return;

      var makeData = await File.ReadAllTextAsync("Data/make.json");
      var manufacturers = JsonSerializer.Deserialize<List<Make>>(makeData);

      await context.AddRangeAsync(manufacturers);
      await context.SaveChangesAsync();
    }
    public static async Task LoadModels(DataContext context)
    {
      if (await context.VehicleModel.AnyAsync()) return;

      var modelData = await File.ReadAllTextAsync("Data/models.json");
      var models = JsonSerializer.Deserialize<List<VehicleModel>>(modelData);

      await context.AddRangeAsync(models);
      await context.SaveChangesAsync();
    }
    public static async Task LoadVehicles(DataContext context)
    {
      if (await context.Vehicles.AnyAsync()) return;

      var vehicleData = await File.ReadAllTextAsync("Data/vehicle.json");
      var vehicles = JsonSerializer.Deserialize<List<Vehicle>>(vehicleData);

      await context.AddRangeAsync(vehicles);
      await context.SaveChangesAsync();
    }
  }
}