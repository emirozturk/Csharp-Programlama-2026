class Program2
{
    public static int degisken = 0;
    static Mutex mutex = new Mutex();
    public static void Fonk1()
    {
        int counter = 0;
        while (counter < 10)
        {
            mutex.WaitOne();
            var x = degisken;
            Thread.Sleep(10);
            x += 10;
            Thread.Sleep(10);
            degisken = x;
            Thread.Sleep(10);
            counter++;
            mutex.ReleaseMutex();
            Console.WriteLine($"Thread 1: {counter}");
        }
    }
    public static void Fonk2()
    {
        int counter = 0;
        while (counter < 10)
        {
            mutex.WaitOne();
            var x = degisken;
            Thread.Sleep(10);
            x += 10;
            Thread.Sleep(10);
            degisken = x;
            Thread.Sleep(10);
            counter++;
            mutex.ReleaseMutex();
            Console.WriteLine($"Thread 2: {counter}");
        }
    }
    public static void Fonk3()
    {
        int counter = 0;
        while (counter < 10)
        {
            mutex.WaitOne();
            var x = degisken;
            Thread.Sleep(10);
            x += 10;
            Thread.Sleep(10);
            degisken = x;
            Thread.Sleep(10);
            counter++;
            mutex.ReleaseMutex();
            Console.WriteLine($"Thread 3: {counter}");
        }
    }
    public static void Main2()
    {
        var t1 = new Thread(Fonk1);
        var t2 = new Thread(Fonk2);
        var t3 = new Thread(Fonk3);
        t1.Start();
        t2.Start();
        t3.Start();
        Console.WriteLine(degisken);
    }
}