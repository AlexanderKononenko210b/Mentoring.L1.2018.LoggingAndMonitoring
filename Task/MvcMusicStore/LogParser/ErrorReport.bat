SET logFile=%1
.\LogParser.exe -i "TEXTLINE" file:ErrorInfoQuery.sql?inputFilePath=%logFile% -o "CSV"
