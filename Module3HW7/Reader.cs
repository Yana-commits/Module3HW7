using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW7
{
    internal class Reader
    {
        public async Task<int> TextReader(string path)
        {
            string text = await File.ReadAllTextAsync(path);

            Int32.TryParse(text, out int result);
            return result;
        }
    }
}
