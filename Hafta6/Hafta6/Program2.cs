/*
class Program
{

    public static void Main()
    {
        var sayiListesi = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var liste = OgrenciListesi.liste;

        Console.WriteLine(sayiListesi.Max());
        Console.WriteLine(liste.Max());
        Console.WriteLine(sayiListesi.Average());
        Console.WriteLine("========================");
        Console.WriteLine(liste.First());
        Console.WriteLine(liste.Last());
        Console.WriteLine("========================");

        var siraliListe = liste.OrderByDescending(x=>x.Ad);
        foreach(var eleman in siraliListe)Console.WriteLine(eleman);
        Console.WriteLine("========================");

        var sonucFirst = liste.First(x => x.Ad.ToLower().Contains("can"));
        var sonucLast = liste.Last(x => x.Ad.ToLower().Contains("can"));
        Console.WriteLine(sonucFirst);

        Console.WriteLine("========================");

        var sonuc = liste.FirstOrDefault(x => x.Ad.ToLower().Contains("xyz"));
        if (sonuc == null)
            Console.WriteLine("Null");



        var ucuncu = liste.Where(x => x.Ad.ToLower().Contains("can") &&
                                      x.Soyad.ToLower().Contains("can"))
                                      .Skip(2)
                                      .Take(1);
        double ortalama = 0;
        for(int i = 0; i < liste.Count; i++)
            ortalama += liste[i].Sinif;
        ortalama /= liste.Count;
        Console.WriteLine(ortalama);
        Console.WriteLine(liste.Select(x=>x.Sinif).Average());

    }
}
*/