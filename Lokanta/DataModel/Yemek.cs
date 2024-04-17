using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokanta.DataModel;

[Table("Yemek")]
public class Yemek
{
    [Key]
    public int Id { get; set; }
    public string Ad { get; set; }
    public float Fiyat { get; set; }    
    public int? YemekTurId { get; set; }

    [ForeignKey("YemekTurId")]
    public YemekTur? YemekTur { get; set; }

}
