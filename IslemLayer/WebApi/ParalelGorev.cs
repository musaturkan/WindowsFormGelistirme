using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslemLayer.WebApi
{
    public class ParalelGorev
    {
        /// <summary>
        /// Ana bir Task altında alt Task olarak tüm alt işlemler başlatılabilir.
        /// 
        /// </summary>
        public void ParalelIslemYap()
        {
            List<Models.Urun> urunListesi = new List<Models.Urun>();
            Task servisCagrilari = Task.Factory.StartNew(() =>
            {
                Task servis1 = Task.Factory.StartNew(() =>
                {
                    //birinci servis çağrısı
                    IslemLayer.WebApi.TestApi api = new IslemLayer.WebApi.TestApi();
                    urunListesi = api.UrunGetir();
                }, TaskCreationOptions.AttachedToParent);
                Task servis2 = Task.Factory.StartNew(() =>
                {
                    //ikinci servis çağrısı
                    IslemLayer.WebApi.TestApi api = new IslemLayer.WebApi.TestApi();
                    api.UrunAra("pencil");
                }, TaskCreationOptions.AttachedToParent);
                Task servis3 = Task.Factory.StartNew(() =>
                {
                    //üçüncü servis çağrısı
                    IslemLayer.WebApi.TestApi api = new IslemLayer.WebApi.TestApi();
                    IslemLayer.Models.Urun yeni = new IslemLayer.Models.Urun();
                    yeni.price = 2547.75M;
                    yeni.title = "Cep Telefonu";
                    yeni.description = "Aciklama";
                    api.UrunEkle(yeni);
                }, TaskCreationOptions.AttachedToParent);
            });
            //tüm alt Task işlemlerinin bitmesini beklemek için Wait kullanılır
            servisCagrilari.Wait();
        }

        /// <summary>
        /// İstenen görevlerin bitmesini beklemek, istenen görevin beklemeden geçilmesini sağlamak
        /// </summary>
        public void ParalelIslemYap2()
        {
            List<Models.Urun> urunListesi = new List<Models.Urun>();
       
                Task servis1 = Task.Factory.StartNew(() =>
                {
                    //birinci servis çağrısı
                    IslemLayer.WebApi.TestApi api = new IslemLayer.WebApi.TestApi();
                    urunListesi = api.UrunGetir();
                }, TaskCreationOptions.AttachedToParent);
                Task servis2 = Task.Factory.StartNew(() =>
                {
                    //ikinci servis çağrısı
                    IslemLayer.WebApi.TestApi api = new IslemLayer.WebApi.TestApi();
                    api.UrunAra("pencil");
                }, TaskCreationOptions.AttachedToParent);
                Task servis3 = Task.Factory.StartNew(() =>
                {
                    //üçüncü servis çağrısı
                    IslemLayer.WebApi.TestApi api = new IslemLayer.WebApi.TestApi();
                    IslemLayer.Models.Urun yeni = new IslemLayer.Models.Urun();
                    yeni.price = 2547.75M;
                    yeni.title = "Cep Telefonu";
                    yeni.description = "Aciklama";
                    api.UrunEkle(yeni);
                }, TaskCreationOptions.AttachedToParent);

                Task[] taskDizi = { servis2, servis3 };

                Task.WaitAll(taskDizi);

        }

        /// <summary>
        /// Paralele görevleri diziye doldurup yönetmek mümkündür
        /// </summary>
        public void ParalelIslemYap3()
        {
            List<Task> gorevDizi= new List<Task>();

            for (int i = 0; i < 10; i++)
            {

                gorevDizi.Add(Task.Factory.StartNew(() =>
                {
                    ///urun bilgi güncelleme işlemleri
                }));
            }

            Task.WaitAll(gorevDizi.ToArray());

        }
    }
}
