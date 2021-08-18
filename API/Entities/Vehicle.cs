using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
  [Table("Vehicle", Schema = "Vehicles")]
  public class Vehicle
  {
    public int Id { get; set; }
    [Column(TypeName = "VARCHAR(20)")]
    public string Color { get; set; }
    [Column(TypeName = "VARCHAR(15)")]
    public string FuelType { get; set; }
    [Column(TypeName = "VARCHAR(40)")]
    public string GearType { get; set; }
    public int MakeId { get; set; }
    public int Mileage { get; set; }
    public int ModelId { get; set; }
    [Column(TypeName = "SMALLINT")]
    public int ModelYear { get; set; }
    public DateTime? RegistrationDate { get; set; }
    [Column(TypeName = "VARCHAR(10)")]
    public string RegistrationNumber { get; set; }
    [Column(TypeName = "VARCHAR(80)")]
    public string VehicleName { get; set; }

    //Navigation Properties
    [ForeignKey("MakeId")]
    public virtual Make Make { get; set; }

    [ForeignKey("ModelId")]
    public virtual VehicleModel Model { get; set; }
  }
}