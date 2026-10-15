class Program
{
    public static void Main1(string[] args)
    {
        Console.WriteLine("=====================================");
        try
        {
            //FileStream stream = new FileStream("/Users/emirozturk/Desktop/deneme2.txt", FileMode.CreateNew);
            //stream.Write(new byte[]{65,66,67},0,3);
            using (var stream = new FileStream("/Users/emirozturk/Desktop/deneme.txt", FileMode.Create))
            {
                /*using (var streamWriter = new StreamWriter(stream))
                {
                    streamWriter.Write($"1.Berat Soylu,");
                    streamWriter.Write($"2.Muratcan Kara,");
                    streamWriter.Write($"3.Yunus Emre Aydın,");
                }
                */
                using (var binaryWriter = new BinaryWriter(stream))
                {
                    binaryWriter.Write(65);
                }
            }
            using (var stream = new FileStream("/Users/emirozturk/Desktop/deneme.txt", FileMode.Open))
            {
                using (var binaryreader = new BinaryReader(stream))
                {
                    Console.WriteLine(binaryreader.ReadChar());
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Dosya mevcut" + ex.Message);
        }
    }
}