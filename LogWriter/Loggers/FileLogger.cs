namespace LogWriter
{
    public class FileLogger:Logger
    {
        private string filePath;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">Путь к файлу логов.</param>
        public FileLogger(string path)
        {
            filePath = path;
        }
        internal override void WriteLog(string log)
        {
            base.WriteLog(log);

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(log);
            }
        }
    }
}