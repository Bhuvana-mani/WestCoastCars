using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class ManufacturerRepository : IManufacturerRepository
  {
    private readonly DataContext _context;
    public ManufacturerRepository(DataContext context)
    {
      _context = context;
    }

    public void Add(Make manufacturer)
    {
      _context.Entry(manufacturer).State = EntityState.Added;
    }
    public async Task<Make> GetManufacturerById(int id)
    {
      return await _context.Make.FindAsync(id);
    }
    public async Task<Make> GetManufacturerByName(string name)
    {
      return await _context.Make.SingleOrDefaultAsync(c => c.Name.ToLower() == name.ToLower());
    }
    public async Task<IEnumerable<Make>> GetManufacturers()
    {
      return await _context.Make.ToListAsync();
    }
    public void Update(Make manufacturer)
    {
      _context.Entry(manufacturer).State = EntityState.Modified;
    }
  }
}