using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
  [Table("Manufacturer", Schema = "Vehicles")]
  public class Make
  {
    public int Id { get; set; }
    [Column(TypeName = "VARCHAR(80)")]
    public string Name { get; set; }

    //Navigation Properties
    public virtual ICollection<Vehicle> Vehicles { get; set; }
  }
}