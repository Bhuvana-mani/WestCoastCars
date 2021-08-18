using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [ApiController]
  [Route("api/users")]
  public class UsersController : ControllerBase
  {
    private readonly DataContext _context;
    public UsersController(DataContext context)
    {
      _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
      return await _context.Users.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
      return await _context.Users.FindAsync(id);
    }

    [HttpPost()]
    public async Task<ActionResult> AddUser(RegisterUserViewModel model)
    {
      var user = new AppUser
      {
        UserName = model.UserName
      };

      _context.Users.Add(user);

      var result = await _context.SaveChangesAsync();

      return StatusCode(201, user);

    }
  }
}