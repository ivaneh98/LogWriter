using LogWriter;


ConsoleLogger consoleLogger = new ConsoleLogger();
consoleLogger.Info("asd");
consoleLogger.Warn("asd");
consoleLogger.Error("asd");
consoleLogger.Debug("asd");

DatabaseLogger dbLogger = new DatabaseLogger("Data Source=logs.db");
dbLogger.Info("asd");
dbLogger.Warn("asd");
dbLogger.Error("asd");
dbLogger.Debug("asd");

FileLogger fileLogger = new FileLogger("logs.txt");
fileLogger.Info("asd");
fileLogger.Warn("asd");
fileLogger.Error("asd");
fileLogger.Debug("asd");