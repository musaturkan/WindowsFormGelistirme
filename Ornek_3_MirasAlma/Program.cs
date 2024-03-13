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

        Arac a = new Arac();
        a = altay;
        a = boeing;
        a = h;
    }
}