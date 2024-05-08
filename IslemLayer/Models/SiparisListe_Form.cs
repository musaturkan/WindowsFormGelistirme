using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslemLayer.Models
{
    public class SiparisListe_Form
    {
        public int Id { get; set; }
        public DateTime? Tarih { get; set; }
        public int MasaAdi { get; set; }
        public int MasaId { get; set; }
        public string? YemekAdi { get; set; }
    }
}
