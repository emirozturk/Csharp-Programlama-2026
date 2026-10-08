using System.Diagnostics;

class Program2
{
    static List<int> liste = new List<int>();
    static HashSet<int> set = new HashSet<int>();
    public static void Main2(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < 1_000_000_000; i++)
        {
            liste.Add(i);
            set.Add(i);
        }
        var ms = sw.ElapsedMilliseconds;
        Console.WriteLine($"Toplam ekleme süresi: {ms} ms");
        sw.Restart();
        for (int i = 0; i < 1_000_000; i++)
        {
            if (!liste.Contains(i))
            {
                liste.Add(i);
            }
        }
        ms = sw.ElapsedMilliseconds;
        Console.WriteLine($"Toplam arama süresi: {ms} ms");
        sw.Restart();
        for (int i = 0; i < 1_000_000; i++)
        {
            if (!set.Contains(i))
            {
                liste.Add(i);
            }
        }
        ms = sw.ElapsedMilliseconds;
        Console.WriteLine($"Toplam hash arama süresi: {ms} ms");
        sw.Stop();
    }
}