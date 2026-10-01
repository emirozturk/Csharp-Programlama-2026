public class RastgeleTahmin
{
    public static int TahminEt()
    {
        return new Random().Next();
    }
    public static int TahminEt(int altSinir, int ustSinir)
    {
        return new Random().Next(altSinir, ustSinir);
    }
    public static int[] TopluTahmin(int n)
    {
        int[] dizi = new int[n];
        for (int i = 0; i < n; i++)
            dizi[i] = TahminEt();
        return dizi;
    }
    public static int[] TopluTahmin(int n, int altSinir, int ustSinir)
    {
        int[] dizi = new int[n];
        for (int i = 0; i < n; i++)
            dizi[i] = TahminEt(altSinir, ustSinir);
        return dizi;
    }
    public static int[] TekrarsizTopluTahmin(int n, int altSinir, int ustSinir)
    {
        var liste = new List<int>();
        while(liste.Count<n)
        {
            int sayi = TahminEt(altSinir,ustSinir);
            if (!liste.Contains(sayi))
                liste.Add(sayi);
        }
        return liste.ToArray();
    }
}