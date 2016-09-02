using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class CommandLine
    {
        private static readonly object _token = new object();

        public static void Write(string text)
        {
            lock (_token)
            {
                Console.WriteLine(text);
            }
        }
    }
}
