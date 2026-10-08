class Sarki
{
    public string Ad { get; set; }
    public string Sanatci { get; set; }
    public int SureSn { get; set; }
    public override string ToString()
    {
        return $"{Ad}   {Sanatci}   {SureSn}";
    }
}
class Program3
{
    /*ToDo
    -Süreler kimi yerde sn kimi yerde dk. Dk alınmalı sn saklanmalı ve dk gösterilmeli
    -Dk gibi değerlerde : girilmediyse hata verip tekrar ekrandan alınmalı doğru format girilene kadar
    -isim, şarkıcı adı veya süre girişlerinde hatalı format kontrolleri yapılmalı
    -Şarkı mevcutsa listeye tekrar eklenmemeli.
    -Sıra ile sil ya da ada göre sil durumlarında sıranın dışında bir değer girilirse hata vermeli ve doğru sıra kontrolü yapmalı
    -Sıradakini çal ya da rastgele çal kısımlarında listenin doluluk durumu kontrol edilmeli
    -Listelemede şarkı, şarkıcı, süre ve sıra numaraları hizalanmalı
    */
    static List<Sarki> liste = new List<Sarki>();
    static Sarki suAndaCalan = null;
    public static void Main(string[] args)
    {
        Menu();
    }

    private static void Menu()
    {
        int secim = 0;
        do
        {
            Listele();
            Console.WriteLine("1. Şarkı ekle");
            Console.WriteLine("2. Albüm ekle");
            Console.WriteLine("3. Ada göre sil");
            Console.WriteLine("4. Sıraya göre sil");
            Console.WriteLine("5. Sıradakini çal");
            Console.WriteLine("6. Rastgele çal");
            Console.WriteLine("7. Listeyi temizle");
            Console.WriteLine("8. Çıkış");
            Console.WriteLine("Seçim:");
            secim = Convert.ToInt32(Console.ReadLine());
            Action? secimIslemi = secim switch
            {
                1 => () => Ekle(),
                2 => () => TopluEkle(),
                3 => () => Sil(),
                4 => () => SiraIleSil(),
                5 => () => SiradakiniCal(),
                6 => () => RastgeleCal(),
                7 => () => ListeyiTemizle(),
                _ => null
            };
            secimIslemi?.Invoke();
        } while (secim != 8);

    }

    private static void Listele()
    {
        Console.WriteLine("=================================");
        for (int i = 0; i < liste.Count; i++)
            Console.WriteLine($"{i + 1}.   " + liste[i]);
        Console.WriteLine($"Toplam {liste.Count} şarkı, toplam {liste.Sum(x => x.SureSn)} sn");
        Console.WriteLine("---------------------------------");
        Console.WriteLine(suAndaCalan != null ? suAndaCalan : "Çalan şarkı yok");
        Console.WriteLine("=================================");
    }

    private static void ListeyiTemizle()
    {
        liste.Clear();
    }

    private static void RastgeleCal()
    {
        var max = liste.Count;
        var rastgele = new Random().Next(0, max);
        suAndaCalan = liste[rastgele];
        liste.RemoveAt(rastgele);
    }

    private static void SiradakiniCal()
    {
        suAndaCalan = liste[0];
        liste.RemoveAt(0);
    }

    private static void SiraIleSil()
    {
        Console.WriteLine("Hangi sıradaki şarkı silinsin:");
        var secim = Convert.ToInt32(Console.ReadLine());
        liste.RemoveAt(secim - 1);
    }

    private static void Sil()
    {
        Console.WriteLine("Hangi şarkı (ad ile) silinsin:");
        var silinecek = Console.ReadLine();
        var bulunan = liste.FirstOrDefault(x => x.Ad.Contains(silinecek));
        if (bulunan != null)
        {
            liste.Remove(bulunan);
        }
    }

    private static void TopluEkle()
    {
        var str = Console.ReadLine();
        var parcalar = str.Split(":");
        foreach (var parca in parcalar)
        {
            var alanlar = parca.Split("-");
            liste.Add(new Sarki()
            {
                Ad = alanlar[0],
                Sanatci = alanlar[1],
                SureSn = Convert.ToInt32(alanlar[2])
            });
        }
    }

    private static void Ekle()
    {
        Console.WriteLine("Şarkı adı giriniz:");
        var sarkiAdi = Console.ReadLine();
        Console.WriteLine("Sanatçı adı giriniz:");
        var sanatciAdi = Console.ReadLine();
        Console.WriteLine("Süre giriniz:");
        var sure = DkToSn(Console.ReadLine());
        var yeniSarki = new Sarki()
        {
            Ad = sarkiAdi,
            Sanatci = sanatciAdi,
            SureSn = sure
        };
        liste.Add(yeniSarki);
    }

    private static int DkToSn(string v)
    {
        //1:52 gibi girilen bir değeri sn değerine çevirir
        var dkSn = v.Split(":");
        return Convert.ToInt32(dkSn[0]) * 60 + Convert.ToInt32(dkSn[1]);
    }
}