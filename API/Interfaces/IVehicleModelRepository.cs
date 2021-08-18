using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
  public interface IVehicleModelRepository
  {
    Task<VehicleModel> GetModelByName(string description);
    Task<VehicleModel> GetModelById(int id);
    Task<IEnumerable<VehicleModel>> GetModels();
    void Add(VehicleModel model);
    void Update(VehicleModel model);
  }
}