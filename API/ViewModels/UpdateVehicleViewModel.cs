using System;

namespace API.ViewModels
{
  public class UpdateVehicleViewModel
  {
    public string FuelType { get; set; }
    public string GearType { get; set; }
    public int Mileage { get; set; }
    public DateTime RegistrationDate { get; set; }
  }
}