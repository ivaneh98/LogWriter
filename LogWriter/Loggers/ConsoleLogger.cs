using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogWriter
{
    public class ConsoleLogger : Logger
    {
        internal override void WriteLog(string log)
        {
            base.WriteLog(log);
            Console.WriteLine(log);
        }
    }
}
