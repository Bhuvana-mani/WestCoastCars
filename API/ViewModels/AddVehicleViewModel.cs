using System;
using System.ComponentModel.DataAnnotations;
using API.ViewModels.Vehicles;

namespace API.ViewModels
{
  public class AddVehicleViewModel : VehicleBaseViewModel
  {
    public string Name { get; set; }
    public string Color { get; set; }
    public string FuelType { get; set; }
    public string GearType { get; set; }
    [Required(ErrorMessage = "Tillverkaren saknas!")]
    public string Make { get; set; }
    public int Mileage { get; set; }
    [Required(ErrorMessage = "Modell beteckning saknas!")]
    public string Model { get; set; }
    public int ModelYear { get; set; }
    public DateTime RegistrationDate { get; set; }
  }
}