﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokanta.DataModel
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
