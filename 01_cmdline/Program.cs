internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        string[] files = Directory.GetFiles(".", "*.*", SearchOption.AllDirectories);
        foreach (string file in files) {
            Console.WriteLine(file);
        }


    }
}