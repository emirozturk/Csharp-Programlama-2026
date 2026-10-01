class Program1
{
    /*
    Bir kahve dükkânı için sipariş alan bir kasa programı yazınız. Menü ekrana yazdırılsın, kullanıcı ürün numarası ve boy (K, O, B) girsin. 0 girildiğinde sipariş kapansın ve fiş yazdırılsın.
    •	Ürün fiyatını boy ek ücretini belirleyiniz (Küçük +0, Orta +10, Büyük +20 TL).
    •	Toplam 300 TL’yi geçerse %10 indirim uygulayınız.
    •	Müşterinin verdiği paraya göre para üstünü hesaplayınız; para yetersizse eksik tutarı yazdırınız.
    */
    static int[] fiyatlar = { 150, 160, 150, 180, 120, 200, 210, 250, 255, 180 };
    public static int Menu()
    {
        Console.WriteLine("Kahve seçiniz:");
        Console.WriteLine("1. Filtre Kahve");
        Console.WriteLine("2. Latte");
        Console.WriteLine("3. Americano");
        Console.WriteLine("4. Flat white");
        Console.WriteLine("5. Türk Kahvesi");
        Console.WriteLine("6. White mocha");
        Console.WriteLine("7. Milkshake");
        Console.WriteLine("8. Sıcak çikolata");
        Console.WriteLine("9. Brownie");
        Console.WriteLine("10. Limonata");
        Console.WriteLine("0. Çıkış");
        Console.WriteLine("Seçim:");
        var secim = Convert.ToInt32(Console.ReadLine());
        return secim;
    }
    public static int BoyutAl()
    {
        Console.WriteLine("Boy seçiniz:");
        Console.WriteLine("1. Küçük");
        Console.WriteLine("2. Orta");
        Console.WriteLine("3. Büyük");
        Console.WriteLine("Seçim:");
        var secim = Convert.ToInt32(Console.ReadLine());
        return secim;
    }
    public static int TutarHesapla(int numara, int boyut)
    {
        var boyutFarki = new int[] { 0, 0, 10, 25 };
        return fiyatlar[numara] + boyutFarki[boyut];
    }
    public static int IndirimYap(int tutar)
    {
        if (tutar > 300) return Convert.ToInt32(tutar * 0.9);
        return tutar;
    }
    public static int ParaAl()
    {
        Console.WriteLine("Alınan tutarı giriniz:");
        var tutar = Convert.ToInt32(Console.ReadLine());
        return tutar;
    }
    public static void SonucYaz(int alinanUcret, int toplamTutar)
    {
        if (alinanUcret > toplamTutar)//Fazlaysa üstünü hesapla, azsa eksik tutarı yazdır.
            Console.WriteLine($"Para üstü: {alinanUcret - toplamTutar}");
        else if (alinanUcret < toplamTutar)
            Console.Write($"Para eksik. Müşteri kaçmasın. Eksik tutar: {toplamTutar - alinanUcret}");
        else
            Console.Write($"Tam ücret alındı borç veya para üstü yok");
    }
    public static void Main1(string[] args)
    {
        int toplamTutar = 0, secilenNumara, boyut;//Öncelikle ekrandan alınacak değerlere değişkenler tanımlamam gerek (Ürün numarası, boy ve toplam tutar)
        do
        {
            secilenNumara = Menu(); //menü yazdırmam gerekiyor,Kullanıcı menüden bir ürün seçecek
            if (secilenNumara == 0) break;
            boyut = BoyutAl(); //Bu ürünün boyutu sorulacak ve alınacak
            toplamTutar += TutarHesapla(secilenNumara, boyut); //Ürün ve boyuta göre fiyat hesaplamam lazım  
            Console.WriteLine($"Toplam tutar: {toplamTutar}");
        } while (secilenNumara != 0);//Kullanıcı ürün olarak 0 girene kadar
        toplamTutar = IndirimYap(toplamTutar);//Toplam tutar > 300 tl ise %10 indirim yap
        Console.WriteLine($"Ödenecek: {toplamTutar}");
        var alinanUcret = ParaAl();//Müşterinin kaç para verdiğini al
        SonucYaz(alinanUcret, toplamTutar);
    }
}