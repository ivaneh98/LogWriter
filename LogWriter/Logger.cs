using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogWriter
{
    public abstract class Logger : ILogger
    {
        /// <summary>
        /// Выведет сообщение в формате "Отладка: [ваше сообщение]."
        /// </summary>
        /// <param name="log">Сообщение для записи в лог.</param>
        public void Debug(string log)
        {
            WriteLog($"Отладка: {log}");
        }

        /// <summary>
        /// Выведет сообщение в формате "Ошибка: [ваше сообщение]."
        /// </summary>
        /// <param name="log">Сообщение для записи в лог.</param>
        public void Error(string log)
        {
            WriteLog($"Ошибка: {log}");
        }

        /// <summary>
        /// Выведет сообщение в формате "Информация: [ваше сообщение]."
        /// </summary>
        /// <param name="log">Сообщение для записи в лог.</param>
        public void Info(string log)
        {
            WriteLog($"Информация: {log}");
        }

        /// <summary>
        /// Выведет сообщение в формате "Предупреждение: [ваше сообщение]."
        /// </summary>
        /// <param name="log">Сообщение для записи в лог.</param>
        public void Warn(string log)
        {
            WriteLog($"Предупреждение: {log}");
        }
        /// <summary>
        /// Выводит сообщение 
        /// </summary>
        /// <param name="log">Лог подгтовленный к выводу</param>
        internal virtual void WriteLog(string log)
        {

        }
    }
}
