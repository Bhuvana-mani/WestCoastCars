using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class VehicleModelRepository : IVehicleModelRepository
  {
    private readonly DataContext _context;
    public VehicleModelRepository(DataContext context)
    {
      _context = context;
    }

    public void Add(VehicleModel model)
    {
      _context.Entry(model).State = EntityState.Added;
    }
    public async Task<VehicleModel> GetModelById(int id)
    {
      return await _context.VehicleModel.FindAsync(id);
    }
    public async Task<VehicleModel> GetModelByName(string description)
    {
      return await _context.VehicleModel.SingleOrDefaultAsync(c => c.Description.ToLower() == description.ToLower());
    }
    public async Task<IEnumerable<VehicleModel>> GetModels()
    {
      return await _context.VehicleModel.ToListAsync();
    }

    public void Update(VehicleModel model)
    {
      _context.Entry(model).State = EntityState.Modified;
    }
  }
}