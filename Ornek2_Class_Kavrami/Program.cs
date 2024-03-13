using Ornek2_Class_Kavrami;
using SavasAraclari;
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int sayi;

        Arac mercedes = new Arac();  //new();
        Arac togg = new Arac();
        mercedes.YakitYukle(25);
        togg.YakitYukle(35);
        togg.YakitYukle(150);
        Console.WriteLine(mercedes.YakitOku());
        Console.WriteLine(togg.YakitOku());

        Ucak kaan = new Ucak();
        kaan.YakitMiktari = 50;
        kaan.YakitMiktari = 40;
        
        kaan.UcakHareketEttir(13);
        kaan.YakitMiktari = 23;
        kaan.UretimYili = 2024;
        Console.WriteLine(kaan.MaksimumMenzil);

        //Matematik hesap = new Matematik();
        //hesap.Topla(15,5);

        Matematik.Topla(45, 4);
    }
}