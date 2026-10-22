class Program
{
    public static void Main()
    {
        var liste = OgrenciListesi.liste;
        //123 numaralı öğrencilerden ad veya soyadında can geçenleri sınıfa göre sıralayıp ikinci kaydın adı ve sınıfını ekrana gösteren uygulama

        var canGecenyirmiucluler = new List<Ogrenci>();
        for (int i = 0; i < liste.Count; i++)
            if (liste[i].Numara.StartsWith("123") && (liste[i].Ad.ToLower().Contains("can") || liste[i].Soyad.ToLower().Contains("can")))
                canGecenyirmiucluler.Add(liste[i]);
        for (int i = 0; i < canGecenyirmiucluler.Count; i++)
            for (int j = 0; j < canGecenyirmiucluler.Count; j++)
                if (canGecenyirmiucluler[i].Sinif < canGecenyirmiucluler[j].Sinif)
                {
                    var temp = canGecenyirmiucluler[i];
                    canGecenyirmiucluler[i] = canGecenyirmiucluler[j];
                    canGecenyirmiucluler[j] = temp;
                }
        Console.WriteLine(canGecenyirmiucluler[1].Ad + " " + canGecenyirmiucluler[1].Sinif);

        //123 numaralı öğrencilerden ad veya soyadında can geçenleri sınıfa göre sıralayıp ikinci kaydın adı ve sınıfını ekrana gösteren uygulama

        var sonuc = liste.Where(x=>x.Numara.StartsWith("123") && 
                               (x.Ad.ToLower().Contains("can") || x.Soyad.ToLower().Contains("can")))
                         .OrderBy(x=>x.Sinif)
                         .Skip(1)
                         .Take(1)
                         .Select(x=>$"{x.Ad} {x.Sinif}").First();
        Console.WriteLine(sonuc);
    }
}
