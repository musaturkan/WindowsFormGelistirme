﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_3_MirasAlma.Oyun
{
    public class Helikopter: _Arac
    {
        public int PervaneCapi { get; set; }

        public override void HareketEt(int km)
        {
            Console.WriteLine("Helikopter hareket etti");
        }
    }
}