using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IslemLayer
{
    public class DTOMapper
    {

        //public S1 Topla<S1,S2>(S1 x, S2 y)
        //{
        //    //typeof
        //    //return x+ y;
        //    return x;
        //}

        //public void GenericMetot<T,T2>(T nense,T2 nesne) where T:struct
        //{

        //}

        /// <summary>
        /// iki parametre ile çalışır. Entity tipi ve dto tipi belirtilerek dönüştürme yapar. dönüşüm yapılacak tip isimleri E ve T
        /// generik bildirimi ile yapılması gerekir.
        /// </summary>
        /// <typeparam name="E">Dönüştürülecek entity tipidir</typeparam>
        /// <typeparam name="T">Dönüşecek dto tipidir</typeparam>
        /// <param name="dtoNesnesi">dönüşece dto nesnesidir</param>
        /// <returns></returns>
        public E EntityeDonustur<E,T>(T dtoNesnesi) where E:class,new() where T:class,new()
        {   
            ///E tipinde bir nesne oluşturulur. E tipinin ne olduğu metodun kullanıldığı yerde bildirilir.
            E entity = new E();

            ///Dto nesnesinin özellik listesi elde edilir.
            var dtoPropertyies = typeof(T).GetProperties().ToList();
          
            ///dto nesnesinin propertylerinde döngü oluşturulur
            foreach(var dtoOzellik in dtoPropertyies)
            {
                    ///sıradaki property ismi ile aynı isimli bir alan E sınıfında var mı          
                    PropertyInfo pinfo= typeof(E).GetProperty(dtoOzellik.Name);

                    ///Dto özelliği ile aynı isime sahip bir alan E sınıfında varsa değer atama işlemine geçilir.
                    if ( pinfo != null)
                    {
                    ///dto nesnesindeki sıradik özelliğin değeri elde edilir.
                        var deger = dtoOzellik.GetValue(dtoNesnesi);

                    ///entity nesnesinde eşleşen alana dto özelliğinin değeri yazılır.
                        pinfo.SetValue(entity,deger);
                    }
                                    
            }

            return entity;
        }
    }
}
