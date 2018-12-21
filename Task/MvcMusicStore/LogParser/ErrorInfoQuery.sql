Select Substr(Text,0,10) as Date, 
	Substr(Text,11,13) as Time, 
	Substr(Text,25,5) as Level, 
	Substr(Text,31) as Message
into ErrorReport.csv
from %inputFilePath%
where Text like '%ERROR%'
