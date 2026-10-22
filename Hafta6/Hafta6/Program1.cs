/*
class Program
{
    static int islemYap(int a, int b, Func<int, int, int> fonk)
    {
        return fonk(a, b);
    }

    public static void Main()
    {
        int a = 30;
        int b = 20;
        //int sonuc = islemYap(a,b);
        //Console.WriteLine(sonuc);
        Func<int, int, int> topla = (a, b) => { return a + b; };
        Func<int, int, int> carp = (a, b) => { return a * b; };
        //Console.WriteLine(topla(1,2));
        Console.WriteLine(islemYap(a, b, topla));
        Console.WriteLine(islemYap(a, b, carp));
        Console.WriteLine(islemYap(a,b,(a, b) => Math.Abs(a - b)));
    }
}
*/