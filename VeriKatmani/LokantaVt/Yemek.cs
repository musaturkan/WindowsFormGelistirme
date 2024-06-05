using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeriKatmani.LokantaVt;

[Table("Yemek")]
public class Yemek
{
    [Key]
    public int Id { get; set; }
    public string Ad { get; set; }
    public decimal Fiyat { get; set; }    
    public int? YemekTurId { get; set; }

    [ForeignKey("YemekTurId")]
    public YemekTur? YemekTur { get; set; }

    public ICollection<Siparis>? Siparis { get; set; }

}
