using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslemLayer.Models
{
    public class MasaGuncelle_DTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad alanı boş geçilemez kardeşim")]
        public string? Ad { get; set; }

        [Required(ErrorMessage = "MasaKodu alanı boş geçilemez kardeşim")]
        public string? MasaKodu { get; set; }

        [Required(ErrorMessage = "KacKisilik alanı boş geçilemez kardeşim")]
        public int? KacKisilik { get; set; }
    }
}
