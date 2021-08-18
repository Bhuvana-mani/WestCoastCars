using System.Threading.Tasks;

namespace API.Interfaces
{
  public interface IUnitOfWork
  {
    IVehicleRepository VehicleRepository { get; }
    IVehicleModelRepository VehicleModelRepository { get; }
    IManufacturerRepository manufacturerRepository { get; }
    Task<bool> Complete();
    bool HasChanges();
  }
}