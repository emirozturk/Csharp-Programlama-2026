class Program1
{
    public static void Yazdir(object sinir)
    {
        int ustSinir = Convert.ToInt32(sinir);
        var sayi1 = new Random().Next(1,ustSinir);   
        Console.WriteLine(sayi1);     
        Thread.Sleep(1);
        var sayi2 = new Random().Next(1,ustSinir);
        Console.WriteLine(sayi2);     
        Thread.Sleep(1);
        var sayi3 = new Random().Next(1,ustSinir);
        Console.WriteLine(sayi3);     
    } 
    public static void Main1()
    {
        var yeniThread = new Thread(Yazdir);
        yeniThread.Start(10);
        Thread.Sleep(1);
        Console.WriteLine("Ana thread sonu");
    }
}