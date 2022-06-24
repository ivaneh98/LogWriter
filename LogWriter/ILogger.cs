using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogWriter
{
    internal interface ILogger:IError,IDebug,IWarn,IInfo
    {
    }
}
