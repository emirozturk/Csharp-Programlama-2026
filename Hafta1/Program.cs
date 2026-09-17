Console.WriteLine("Hello, World!");
string? ekrandanAlinan = Console.ReadLine();
for(int i=0;i<ekrandanAlinan?.Length;i++)
{
    Console.WriteLine(ekrandanAlinan[i] + " ");
}