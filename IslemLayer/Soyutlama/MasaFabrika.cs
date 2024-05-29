using AutoMapper.Execution;
using IslemLayer.Masa_Islem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IslemLayer.Soyutlama
{
    /// <summary>
    /// IMasa arayüzünden türüyene sınıfların isimleri enum ile belirtildi
    /// </summary>
    public enum MasaTipi
    {
        MasaIslem,
        CalismaMasasi
    }
    /// <summary>
    /// Masa üretim sınıfıdır. Belirtilen nesne türüne göre IMasa sınıfından 
    /// türetilen nesnelerden birini döndürür
    /// </summary>
    public class MasaFabrika
    {
        /// <summary>
        /// Oluşturulacak nesne tipini enum parametresi ile belirterek nesne elde edilebilir.
        /// </summary>
        /// <param name="NesneTipi"></param>
        /// <returns></returns>
        public static IMasa MasaOlustur(MasaTipi NesneTipi)
        {
            if (NesneTipi==MasaTipi.MasaIslem)
            {
                return new MasaIslem();
            }
            else if(NesneTipi==MasaTipi.CalismaMasasi)
            {
                return new CalismaMasasi();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Nesne oluşturma ihtiyacı olan yerde nesne tipi generic tip ile belirtilebilir
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IMasa MasaOlusturGeneric<T>()where T:class,IMasa,new() 
        {
            if (typeof(T).GetType() == typeof(MasaIslem).GetType())
            {
                return new MasaIslem();
            }
            else if (typeof(T).GetType() == typeof(CalismaMasasi).GetType())
            {
                return new CalismaMasasi();
            }
            else
            {
                return new MasaIslem() ;
            }
        }

        /// <summary>
        /// Generic tip ile belirtilen nesne tipindeki tüm yapıcı metotlar aynı parametre
        /// yapısında ise aşağıdaki gibi de kullanım olabilir.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IMasa MasaOlusturGeneric2<T>() where T : class, IMasa,new()
        {
            return new T();
        }

        //public IMasa MasaOlustur()
        //{
        //    throw new NotImplementedException();
        //}

        //IMasa IMasaFabrika.MasaOlusturGeneric<T>()
        //{
        //    throw new NotImplementedException();
        //}

        //IMasa IMasaFabrika.MasaOlusturGeneric2<T>()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
