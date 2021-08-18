using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
  public interface IManufacturerRepository
  {
    Task<Make> GetManufacturerByName(string name);
    Task<Make> GetManufacturerById(int id);
    Task<IEnumerable<Make>> GetManufacturers();
    void Add(Make manufacturer);
    void Update(Make manufacturer);
  }
}