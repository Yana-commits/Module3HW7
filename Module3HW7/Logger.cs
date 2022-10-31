using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Module3HW7
{
    internal class Logger
    {
        private List<LogItem> activeLogItems = new List<LogItem>();
        private int index = 0;
        //private string path = @"C:\A_level\test.txt";

        private static Logger instance;

        private Logger()
        { }

        public static Logger GetInstance()
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }

        public event Action action;

        public void Log(LogItem item, int N)
        {
            activeLogItems.Add(item);
            index++;

            if (index >= N)
            {
                index = 0;
                action?.Invoke();
            }
        }

        public async Task WriteText()
        {
            var text = new StringBuilder();
            for (int i = 0; i < activeLogItems.Count; i++)
            {
                var item = activeLogItems[i];

                text.AppendLine("Type:" + item.Type + "Messge:" + item.Messege);
            }

            var path = String.Format("Backup\\{0}.txt", DateTime.Now.ToString("yyMMddHHmmssfff"));
            await File.WriteAllTextAsync( path, text.ToString());
            Console.WriteLine($"{text}");
        }
    }
}
