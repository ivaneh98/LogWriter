using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogWriter
{
    internal interface IError
    {
        void Error(string log);
    }
}
