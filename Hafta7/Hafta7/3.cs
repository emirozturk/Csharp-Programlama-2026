class Program3
{
    public static int degisken = 0;
    static Semaphore semaphore = new Semaphore(3, 10);
    public static void Fonk(object i)
    {
        int threadNo = Convert.ToInt32(i);
        int counter = 0;
        while (counter < 10)
        {
            semaphore.WaitOne();
            var x = degisken;
            x += 10;
            degisken = x;
            counter++;
            semaphore.Release();
            Console.WriteLine($"Thread {threadNo}: {degisken}");
        }
    }

    public static void Main3()
    {
        for (int i = 0; i < 100; i++)
        {
            var t1 = new Thread(Fonk);
            t1.Start(i);
        }
        Thread.Sleep(60000);
        Console.WriteLine(degisken);
    }
}