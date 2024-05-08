﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriKatmani.LokantaVt;

namespace IslemLayer.Masa_Islem
{
    public class MasaIslem
    {
        LokantaContext context=new LokantaContext();

        /// <summary>
        /// Bu metot yeni bir masa kaydı ekler. 
        /// </summary>
        /// <param name="yeniMasa">Masa entity tipinden bir parametre ile çalışır. 
        /// Ad, masakodu alanı boş olmayan kayıtlar eklenir.</param>
        //public void MasaEkle(VeriKatmani.LokantaVt.Masa yeniMasa)
        //{
        //    if (yeniMasa != null && yeniMasa.Ad!=null && yeniMasa.MasaKodu!=null)
        //    {
        //        //LokantaContext model = new LokantaContext();
        //        context.Masa.Add(yeniMasa);
        //        context.SaveChanges();
        //    }

        //}

        public void MasaEkle(Models.MasaGuncelle_DTO yeniMasa)
        {
            if (yeniMasa != null && yeniMasa.Ad != null && yeniMasa.MasaKodu != null)
            //if(//buraya modelin validation durumunu kontrol eden kod bulunup yazılacak)
            {
                Masa masa = new Masa();
                masa.MasaKodu = yeniMasa.MasaKodu;
                masa.Ad = yeniMasa.Ad;
                masa.KacKisilik = yeniMasa.KacKisilik;

                context.Masa.Add(masa);
                context.SaveChanges();
            }

        }

        /// <summary>
        /// Tüm masaların bir listesini döndürür.
        /// </summary>
        /// <returns>Masa entity tipinde bir List elemanıdır.</returns>
        public List<Models.Masa_Poco> MasaListeGetir()
        {
            //LokantaContext model = new LokantaContext();

            //var liste = context.Masa.ToList();
            var liste = (from m in context.Masa
                         select new Models.Masa_Poco
                         {
                             Id = m.Id,
                             Ad = m.Ad,
                             MasaKodu = m.MasaKodu
                         }).ToList();

            //var liste2 = context.Masa.Select(p => new Models.Masa_Poco
            //            {
            //                Id = p.Id,
            //                Ad = p.Ad,
            //                MasaKodu=p.MasaKodu

            //            }).ToList();

            return liste;
        }

        /// <summary>
        /// Masa silme işlemi yapar. Idsi verilen kaydı veri tabanından siler.
        /// </summary>
        /// <param name="MasaId">Silinecek masanın id numarasıdır.</param>
        public void MasaSil(int MasaId)
        {
            //LokantaContext model = new LokantaContext();
            var silinecekKayit=context.Masa.FirstOrDefault(p=>p.Id==MasaId);
            context.Masa.Remove(silinecekKayit);
            context.SaveChanges();
        }

        /// <summary>
        /// Masa nesnesini günceller.
        /// </summary>
        /// <param name="yeniMasa">Masa idsi dolu olarak masanın yeni bilgilerini taşıyan masa nesnesidir.</param>
        public void MasaGuncelle(Models.MasaGuncelle_DTO yeniMasa)
        {

            if (yeniMasa != null && yeniMasa.Ad != null && yeniMasa.MasaKodu != null)
            {
                //LokantaContext model = new LokantaContext();

                var guncellenecekMasa=context.Masa.FirstOrDefault(p=>p.Id==yeniMasa.Id);

                guncellenecekMasa.MasaKodu = yeniMasa.MasaKodu;
                guncellenecekMasa.Ad = yeniMasa.Ad;
                guncellenecekMasa.KacKisilik = yeniMasa.KacKisilik;

                context.SaveChanges();
            }
        }


    }
}
