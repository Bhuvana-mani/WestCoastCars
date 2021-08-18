using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("api")]
  public class VehicleMakeController : ControllerBase
  {
    private readonly IUnitOfWork _unitOfWork;
    public VehicleMakeController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet("manufacturers")]
    public async Task<ActionResult<IList<ManufacturerViewModel>>> GetManufacturers()
    {
      return Ok(await _unitOfWork.manufacturerRepository.GetManufacturers());
    }

    [HttpPost("manufacturer")]
    public async Task<ActionResult> Add(ManufacturerViewModel model)
    {
      try
      {
        var manufacturer = await _unitOfWork.manufacturerRepository.GetManufacturerByName(model.Name);

        if (manufacturer != null) { return BadRequest("Tillverkaren finns redan i systemet!"); }

        var make = new Make
        {
          Name = model.Name
        };

        _unitOfWork.manufacturerRepository.Add(make);

        if (await _unitOfWork.Complete()) return StatusCode(201, make);

        return StatusCode(500, "Det gick inte att spara ner tillverkaren");
      }
      catch (Exception ex)
      {
        return StatusCode(500, ex.Message);
      }

    }

    [HttpPut("manufacturer/{id}")]
    public async Task<ActionResult> Update(int id, ManufacturerViewModel model)
    {
      try
      {
        var manufacturer = await _unitOfWork.manufacturerRepository.GetManufacturerById(id);
        if (manufacturer == null) return NotFound($"Kunde inte hitta någon tillverkare med id: {id}");

        manufacturer.Name = model.Name;

        _unitOfWork.manufacturerRepository.Update(manufacturer);

        if (await _unitOfWork.Complete()) return NoContent();

        return StatusCode(500, "Det gick inte att uppdatera tillverkaren");
      }
      catch (Exception ex)
      {
        return StatusCode(500, ex.Message);
      }

    }
  }
}