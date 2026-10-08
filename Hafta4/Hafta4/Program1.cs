class FormatliYazdir
{
    public static void SatirlaYazdir<T>(T sayi)
    {
        Console.WriteLine($"=============== {sayi} ===============");
    }
    /*
    public static void SatirlaYazdir(int sayi)
    {
        Console.WriteLine($"=============== {sayi} ===============");
    } 
    public static void SatirlaYazdir(double sayi)
    {
        Console.WriteLine($"=============== {sayi} ===============");        
    }

    internal static void SatirlaYazdir(string stringDeger)
    {
        Console.WriteLine($"=============== {stringDeger} ===============");        
    }
    */
}
class Program1
{
    public static void Main1(string[] args)
    {
        int tamSayiDeger = 33;
        double doubleDeger = 23.8;
        string stringDeger = "12.3";
        object x = new object();
        FormatliYazdir.SatirlaYazdir(tamSayiDeger);
        FormatliYazdir.SatirlaYazdir(doubleDeger);
        FormatliYazdir.SatirlaYazdir(stringDeger);
        FormatliYazdir.SatirlaYazdir(x);
    }
}