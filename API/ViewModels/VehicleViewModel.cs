using System;
using API.Entities;
using API.ViewModels.Vehicles;

namespace API.ViewModels
{
  public class VehicleViewModel : VehicleBaseViewModel
  {
    public int Id { get; set; }
    public string Color { get; set; }
    public string FuelType { get; set; }
    public string GearType { get; set; }
    public string Make { get; set; }
    public int Mileage { get; set; }
    public string Model { get; set; }
    public int ModelYear { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public string VehicleName { get; set; }
  }
}