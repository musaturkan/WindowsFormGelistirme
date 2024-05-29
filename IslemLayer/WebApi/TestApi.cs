using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IslemLayer.WebApi
{
    public class TestApi
    {
        public List<Models.Urun> UrunGetir()
        {
            HttpClient client = new HttpClient();

            Uri adres = new Uri("https://dummyjson.com/products");

            var sonuc = client.GetAsync(adres).Result;

            var veri = sonuc.Content.ReadAsStringAsync().Result;

            ///Json nesnesine dönüştürme işlemleri burada yapılacak.           
            var verisonuc = JsonSerializer.Deserialize<Models.ApiSonuc>(veri);

            return verisonuc.products;
        }

        public void UrunAra(string urunAdi)
        {
            //'https://dummyjson.com/posts/search?q=love'
            
            Uri adres = new Uri("https://dummyjson.com/products/search?q=" + urunAdi);
            HttpClient client = new HttpClient();

            var sonuc =client.GetAsync(adres).Result;

        }

        /// <summary>
        /// Post işlemi yapmak için HttpClient nesnesi kullanımı örneğidir. Ürün nesnesini ilgili api
        /// metoduna post olarak gönderir.
        /// </summary>
        /// <param name="yeniUrun"></param>
        public void UrunEkle(Models.Urun yeniUrun)
        {            
            Uri adres = new Uri("https://dummyjson.com/products/add");
            string urunJson= JsonSerializer.Serialize(yeniUrun);
            StringContent content= new StringContent(urunJson,Encoding.UTF8);
            HttpClient client = new HttpClient();
            var sonuc = client.PostAsync(adres, content).Result;

        }

        public async void HavaDurumuGetir()
        {
            //        https://api.open-meteo.com/v1/forecast"
            //params = {
            //                "latitude": 13.410007,
            //	"longitude": 13.410007,
            //	"hourly": "temperature_2m",
            //	"daily": "weather_code",
            //	"timezone": "Europe/Berlin"
            //}
            //        }

            Models.ApiParametre parametre = new Models.ApiParametre();
            parametre.latitude= 13.410007M;
            parametre.longitude = 13.410007M;
            parametre.timezone = "Europe/Berlin";
            parametre.daily = "weather_code";
            parametre.hourly = "temperature_2m";

            var serializeParametre = JsonSerializer.Serialize(parametre);
            StringContent content = new StringContent(serializeParametre,Encoding.UTF8,"application/json");
           
            HttpClient client = new HttpClient();
            Uri adres = new Uri("https://api.open-meteo.com/v1/forecast");
          
            
            var response = await client.PostAsync(adres,content);
            var veri = await response.Content.ReadAsStringAsync();

        }
    }
}
