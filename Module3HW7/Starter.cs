using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW7
{
    internal class Starter
    {
        public static string path => "TextFile.txt";

        LogCreator creator = new LogCreator();
        Reader reader = new Reader();

        public async Task RunAsync()
        {
            Logger.GetInstance().action += MakeNotes;

            var n = await reader.TextReader(path);

            creator.AddItems();

            await Counter(n);

            await Counter(n);
        }

        public async void MakeNotes() => await Logger.GetInstance().WriteText();

        public async Task Counter(int n)
        {
            for (var i = 0; i < 50; i++)
            {
                await Task.Delay(1000);
                creator.DoLog(n);
            }
        }
    }
}
