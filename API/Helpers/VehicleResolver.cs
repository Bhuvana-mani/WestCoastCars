using System.Linq;
using API.Data;
using API.Entities;
using API.ViewModels;
using AutoMapper;

namespace API.Helpers
{
  public class VehicleMakeResolver : IValueResolver<VehicleViewModel, Vehicle, Make>
  {
    public Make Resolve(VehicleViewModel source, Vehicle destination, Make destMember, ResolutionContext context)
    {
      var repo = context.Items["repo"] as DataContext;
      var result = repo.Make.SingleOrDefault(c => c.Name.ToLower() == source.Make);
      return result;
    }
  }

  public class AddVehicleMakeResolver : IValueResolver<AddVehicleViewModel, Vehicle, Make>
  {
    public Make Resolve(AddVehicleViewModel source, Vehicle destination, Make destMember, ResolutionContext context)
    {
      var repo = context.Items["repo"] as DataContext;
      var result = repo.Make.SingleOrDefault(c => c.Name.ToLower() == source.Make);
      return result;
    }
  }

  public class VehicleModelResolver : IValueResolver<VehicleViewModel, Vehicle, VehicleModel>
  {
    public VehicleModel Resolve(VehicleViewModel source, Vehicle destination, VehicleModel destMember, ResolutionContext context)
    {
      var repo = context.Items["repo"] as DataContext;
      var result = repo.VehicleModel.SingleOrDefault(c => c.Description.ToLower() == source.Model);
      return result;
    }
  }

  public class AddVehicleModelResolver : IValueResolver<AddVehicleViewModel, Vehicle, VehicleModel>
  {
    public VehicleModel Resolve(AddVehicleViewModel source, Vehicle destination, VehicleModel destMember, ResolutionContext context)
    {
      var repo = context.Items["repo"] as DataContext;
      var result = repo.VehicleModel.SingleOrDefault(c => c.Description.ToLower() == source.Model);
      return result;
    }
  }
}