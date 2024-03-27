using Ornek_3_MirasAlma.Oyun;

public class Program
{
    private static void Main(string[] args)
    {
        Tank altay=new Tank();
        Tank m60=new Tank();

        altay.YakitMiktari = 25;
        altay.Marka = "Altay";

        Ucak boeing=new Ucak();
        boeing.YakitMiktari=25;
        
        Helikopter h = new Helikopter();

        //Arac a = new Arac();
        //a = altay;
        //a = boeing;
        //a = h;

        //_Arac k=new _Arac();

        List<_Arac> liste = new List<_Arac>();
        liste.Add(altay);
        liste.Add(m60);
        liste.Add(boeing);
        liste.Add(h);

        foreach (var siradakiArac in liste)
        {
            siradakiArac.HareketEt(10);
        }

        AracHareketEttir(altay, 50);
        AracHareketEttir(boeing, 20);
        AracHareketEttir(h, 100);
        Otomobil o =new Otomobil();
        AracHareketEttir(o, 25);

        Hareket<Tank>(altay, 50);
        Hareket<Ucak>(boeing, 20);
        Hareket<Helikopter>(h, 100);
    }

    public static void AracHareketEttir(_Arac arac, int km)
    {
        arac.HareketEt(km);
    }

    public static void Hareket<T>(T arac, int km)where T : _Arac
    {
        arac.HareketEt(km);
    }



}