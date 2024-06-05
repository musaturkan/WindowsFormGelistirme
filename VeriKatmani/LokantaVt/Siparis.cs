using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriKatmani.LokantaVt
{
    [Table("Siparis")]
    public class Siparis
    {
        [Key]
        public int Id { get; set; }
        public int? MasaId { get; set; }
        public int? YemekId { get; set; }
        public DateTime? Tarih { get; set; }

        [ForeignKey("MasaId")]
        public virtual Masa? Masa { get; set; }

        [ForeignKey("YemekId")]
        public virtual Yemek? Yemek { get; set; }

    }
}
