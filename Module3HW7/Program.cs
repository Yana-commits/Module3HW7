using Module3HW7;

internal class Program
{
    public static string path => "TextFile.txt";
    async static Task Main(string[] args)
    {
        //LogCreator creator = new LogCreator();
        //Reader reader1 = new Reader();

        //var n = await reader1.TextReader(path);

        //creator.AddItems();

        //for (var i = 0; i < 50; i++)
        //{
        //    creator.DoLog(n);
        //}

        Starter starter = new Starter();

        await starter.RunAsync();
    }
}