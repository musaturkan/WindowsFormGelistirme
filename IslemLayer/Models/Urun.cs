using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslemLayer.Models
{

    public class ApiSonuc
    {
        public List<Urun> products { get; set; }
    }
    public class Urun
    {
        public string name { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public decimal discountPercentage { get; set; }
        public decimal rating { get; set; }
        public string description { get; set; }

        public decimal price { get; set; }
    }

    public class ApiParametre
    {
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public string hourly { get; set; }
        public string daily { get; set; }
        public string timezone { get; set; }
        
    }
}
