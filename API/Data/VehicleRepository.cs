using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using API.ViewModels;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class VehicleRepository : IVehicleRepository
  {
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public VehicleRepository(DataContext context, IMapper mapper)
    {
      _mapper = mapper;
      _context = context;
    }
    

    public void Add(AddVehicleViewModel vehicle)
    {
      var vehicleToAdd = _mapper.Map<Vehicle>(vehicle, opt =>
      {
        opt.Items["repo"] = _context;
      });
      _context.Entry(vehicleToAdd).State = EntityState.Added;
    }

    public void Delete(VehicleViewModel vehicle)
    {
      _context.Entry(vehicle).State = EntityState.Deleted;
    }

    public async Task<VehicleViewModel> GetVehicleByIdAsync(int id)
    {
      return await _context.Vehicles
        .ProjectTo<VehicleViewModel>(_mapper.ConfigurationProvider)
        .SingleOrDefaultAsync(c => c.Id == id);
    }

    public async Task<VehicleViewModel> GetVehicleByRegNoAsync(string regNo)
    {
      return await _context.Vehicles
      .ProjectTo<VehicleViewModel>(_mapper.ConfigurationProvider)
      .SingleOrDefaultAsync(c => c.RegNumber.ToLower() == regNo.ToLower());
    }

    public async Task<IEnumerable<VehicleViewModel>> GetVehiclesAsync()
    {
      return await _context.Vehicles
        .ProjectTo<VehicleViewModel>(_mapper.ConfigurationProvider)
        .ToListAsync();
    }

    public void Update(VehicleViewModel vehicle)
    {
      var vehicleToUpdate = _mapper.Map<Vehicle>(vehicle, opt =>
      {
        opt.Items["repo"] = _context;
      });
      _context.Entry(vehicleToUpdate).State = EntityState.Modified;
    }
  }
}