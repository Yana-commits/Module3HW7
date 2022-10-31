using Module3HW7;

internal class Program
{
    public static string path => "TextFile.txt";
    async static Task Main(string[] args)
    {
       
        Starter starter = new Starter();

        await starter.RunAsync();
    }
}