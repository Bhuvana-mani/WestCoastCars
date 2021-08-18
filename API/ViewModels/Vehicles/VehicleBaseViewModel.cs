using System.ComponentModel.DataAnnotations;

namespace API.ViewModels.Vehicles
{
  public class VehicleBaseViewModel
  {
    [Required]
    public string RegNumber { get; set; }
  }
}