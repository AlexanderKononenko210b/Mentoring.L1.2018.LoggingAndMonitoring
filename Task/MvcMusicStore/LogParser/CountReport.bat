SET logFile=%1
.\LogParser.exe -i "TEXTLINE" file:CountLoggerInfo.sql?inputFilePath=%logFile% -o "CSV"
