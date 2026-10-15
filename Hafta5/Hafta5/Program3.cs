class Kayit(string Ad, string Soyad)
{
    public string Ad { get; set; } = Ad;
    public string Soyad { get; set; } = Soyad;

    public string ToCsv()
    {
        return $"{Ad},{Soyad}";
    }
    public static Kayit FromCsv(string csv)
    {
        var parcalar = csv.Replace("\n", "").Split(",");
        return new Kayit(parcalar[0],parcalar[1]);
    }
    public override string ToString()
    {
        return $"{Ad} {Soyad}"; 
    }
}
class Program3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        var filePath = "/Users/emirozturk/Desktop/deneme.txt";
        List<Kayit> liste = new List<Kayit>()
        {
            new Kayit("Emir","Öztürk"),
            new Kayit("Muratcan","Kara"),
            new Kayit("Esat Canbek", "Tufan")
        };
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            var stringListesi = liste.Select(x => x.ToCsv());
            File.WriteAllLines(filePath, stringListesi);
        }
        var yeniListe = File.ReadAllLines(filePath).Select(x=>Kayit.FromCsv(x));
        foreach(var eleman in yeniListe)
            Console.WriteLine(eleman);
    }
}