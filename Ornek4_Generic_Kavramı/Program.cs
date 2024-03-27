using Ornek4_Generic_Kavramı;

internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        string b;
        Console.WriteLine("Hello, World!");

        List<int> list = new List<int>();
        List<string> list2 = new List<string>();

        Hesaplama hesaplama = new Hesaplama();

        hesaplama.Toplama<int>(23, 34);

        hesaplama.Toplama<double>(25,54);

    }
}