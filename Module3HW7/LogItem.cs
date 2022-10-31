using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW7
{
    internal class LogItem
    {
        private string messege;
        private LogType type;

        public string Messege
        { 
        get { return messege; }
        }

        public LogType Type
        {
            get { return type; }
        }

        public LogItem(string _messege, LogType _type)
        {
            messege = _messege;
            type = _type;
        }
    }
}
