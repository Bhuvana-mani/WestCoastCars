using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.ViewModels;

namespace API.Interfaces
{
  public interface IVehicleRepository
  {
    void Add(AddVehicleViewModel vehicle);
    Task<IEnumerable<VehicleViewModel>> GetVehiclesAsync();
    Task<VehicleViewModel> GetVehicleByRegNoAsync(string regNo);
    Task<VehicleViewModel> GetVehicleByIdAsync(int id);
    void Delete(VehicleViewModel vehicle);
    void Update(VehicleViewModel vehicle);
  }
}