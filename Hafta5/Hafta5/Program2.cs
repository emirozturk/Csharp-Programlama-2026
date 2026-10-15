class Program2
{
    public static void Main2(string[] args)
    {
        var filePath = "/Users/emirozturk/Desktop/deneme.txt";
        Console.WriteLine("=====================================");
        string yazilacak = "1.Berat Soylu\n2.Muratcan Kara\n3.Yunus Emre Aydın\n";
        File.WriteAllText(filePath,yazilacak);

        var okunan = File.ReadAllText(filePath);
        Console.WriteLine(okunan);

        var okunanSatirlar = File.ReadAllLines(filePath);
        
        var okunanBinaryData = File.ReadAllBytes(filePath);

        //if(File.Exists(filePath))Console.WriteLine("Dosya mevcut");
        //File.Copy(filePath,"/Users/emirozturk/Downloads/dosyaadi.txt");

        Console.WriteLine(Directory.GetCreationTime("/Users/emirozturk/Desktop/RAG"));
        foreach(var element in Directory.GetFiles("/Users/emirozturk/Desktop/RAG"))
            Console.WriteLine(element);
        foreach(var element in Directory.GetLogicalDrives())
        {
            Console.WriteLine(element);
        }
        var directory = "/Users/emirozturk/Desktop";
        var dosyaAdi = "deneme.txt";
        var dosyaYolu = Path.Combine(directory,dosyaAdi);
        File.ReadAllLines(dosyaYolu);
        Console.WriteLine(Path.GetFileName(dosyaYolu));
        Console.WriteLine(Path.GetFileNameWithoutExtension(dosyaYolu));
        Console.WriteLine(Path.GetExtension(dosyaYolu));
         //using (StreamWriter sw = new StreamWriter(filePath))
        //{
        //    for (long i = 0; i < 19_000_000; i++)
        //    {
        //        sw.Write("0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
        //    }
        //}
        //using (StreamReader sr = new StreamReader(filePath))
        //{
        //    while (!sr.EndOfStream)
        //    {
        //        sr.Read();
        //    }
        //}
        //var x = File.ReadAllBytes(filePath);
    }
}