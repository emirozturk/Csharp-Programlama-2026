
class Program
{
    static void EkranaYazdir(int[] dizi)
    {
        foreach (var eleman in dizi)
            Console.Write(eleman + " ");
        Console.WriteLine();
    }
    static void EkranaYazdir(int deger)
    {
        Console.WriteLine($"Deger: {deger}");
    }
    static int EslesmeSayisiHesapla(int[] dizi, int deger)
    {
        int sayac=0;
        for(int i=0;i<dizi.Length;i++)//Dizinin sıfırıncı elemanından son elemanına kadar
            if(dizi[i] == deger)//eğer dizinin sıradaki elemanı deger'e eşitse
                sayac++;//Sayacı bir arttır
        return sayac;//sayacı döndür
    }
    public static void Main(string[] args)
    {
        var dizi = RastgeleTahmin.TekrarsizTopluTahmin(10,1,12);
        var tahmin = RastgeleTahmin.TahminEt(1,100);
        EkranaYazdir(dizi);
        EkranaYazdir(tahmin);
        var eslesme = EslesmeSayisiHesapla(dizi, tahmin);
        EkranaYazdir(eslesme);
    }
}