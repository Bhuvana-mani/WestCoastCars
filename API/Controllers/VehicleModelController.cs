using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Interfaces;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [ApiController]
  [Route("api/vehiclemodel")]
  public class VehicleModelController : ControllerBase
  {
    private readonly IUnitOfWork _unitOfWork;
    public VehicleModelController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet()]
    public async Task<ActionResult<IList<VehicleModel>>> GetVehicleModels()
    {
      return Ok(await _unitOfWork.VehicleModelRepository.GetModels());
    }

    [HttpPost()]
    public async Task<ActionResult> Add(VehicleModelViewModel model)
    {
      try
      {
        var result = await _unitOfWork.VehicleModelRepository.GetModelByName(model.Description);

        if (result != null) return BadRequest("Bilmodellen existerar redan i systemet!");

        var newModel = new VehicleModel
        {
          Description = model.Description
        };

        _unitOfWork.VehicleModelRepository.Add(newModel);
        if (await _unitOfWork.Complete()) return StatusCode(201, newModel);
        return StatusCode(500, "Det gick inte att spara ner ny bilmodell");

      }
      catch (Exception ex)
      {
        return StatusCode(500, ex.Message);
      }
    }
  }
}