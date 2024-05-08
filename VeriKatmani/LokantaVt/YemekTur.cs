using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeriKatmani.LokantaVt
{
    [Table("YemekTur")]
    public class YemekTur
    {
        [Key]
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? KisaAd { get; set; }
        public ICollection<Yemek>? Yemek { get; set; }
    }
}
