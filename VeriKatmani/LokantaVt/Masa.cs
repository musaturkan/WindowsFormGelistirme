using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeriKatmani.LokantaVt;

[Table("Masa")]
public class Masa
{
    [Key]
    public int Id { get; set; }
    public string? Ad { get; set; }
    public string? MasaKodu { get; set; }
    public int? KacKisilik { get; set; }
    
    [Column("Eklenme_Tarihi")]
    public DateTime? EklenmeTarihi { get; set; }
}
