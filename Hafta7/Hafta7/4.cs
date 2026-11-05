using System.Diagnostics;
using System.Linq.Expressions;

class Program4
{
    static List<int> liste = new List<int>();
    static void ListeGoster(string baslik)
    {
        Console.WriteLine($"=============={baslik}==============");
        for (int i = 0; i < liste.Count; i++)
            Console.Write(liste[i] + " ");
        Console.WriteLine();
    }
    public static async Task Fonk1()
    {
        for (int i = 0; i < 10; i++)
        {
            liste.Add(i * 10);
            Thread.Sleep(100);
        }
    }
    public static async Task Fonk2()
    {
        for (int i = 0; i < 10; i++)
        {
            liste.Add(i * 20);
            Task.Delay(10);
        }
    }
    public static async Task Fonk3()
    {
        await Fonk1();
        ListeGoster("Fonk1 sonrası");
        await Fonk2();
        ListeGoster("Fonk2 sonrası");
    }


    public static async Task Main()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        ListeGoster("Başlangıç");
        Console.WriteLine("Ana thread");
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
}