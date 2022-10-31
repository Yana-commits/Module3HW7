using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW7
{
    internal class LogCreator
    {
        private List<LogItem> logItems = new List<LogItem>();

        public void AddItems()
        {
            logItems.Add(new LogItem("Star method",LogType.Info));
            logItems.Add(new LogItem("Skipped logic in method", LogType.Warning));
            logItems.Add(new LogItem("I broke a logic", LogType.Erorr));
        }

        public void DoLog(int N)
        {
            var item = logItems[new Random().Next(0, logItems.Count)];

            Logger.GetInstance().Log(item, N);
        }
    }
}
