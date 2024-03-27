using Ornek5_MirasAlma_2.Oyun.Arac;
using Ornek5_MirasAlma_2.Oyun.Silah;
using Kullanicilar;

internal class Program
{
    private static void Main(string[] args)
    {
        Asker asker1=new Asker();
        asker1.Silah = new Tabanca();
        asker1.Silah.AtesEt();

        asker1.Silah = new Tufek();
        asker1.Silah .AtesEt();

        asker1.SilahListe.Add(new Tufek());
        asker1.SilahListe.Add(new Tabanca());
        asker1.SilahListe.Add(new Bicak());

        asker1.Arac = new Tank();
        asker1.Arac.SilahList.Add(new Top());
        asker1.Arac.SilahList.Add(new MakinaliTufek());

        asker1.Arac.AtestEt();

        Tabanca t = new Tabanca();
        Tabanca t2=new Tabanca(2,50,"Sarsılmaz");

        AtesEt(t2);

        Ucak u1=new Ucak();
        u1.AracKomutani = asker1;
        u1.SilahList.Add(t);


    }

    public static void AtesEt(Silah silah)
    {
        Tabanca t = new Tabanca();
        t.AtesEt();
        silah.AtesEt();
    }
}