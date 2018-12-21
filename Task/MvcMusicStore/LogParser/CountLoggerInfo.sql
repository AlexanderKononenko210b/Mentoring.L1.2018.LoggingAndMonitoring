Select trim(substr(text, 25, 5)) as Level, 
    	count([Index]) as Total
into CountErrorReport.csv
from %inputFilePath%
where (case trim(substr(text, 25, 5)) 
        when 'ERROR' then 1 
        when 'DEBUG' then 1
        when 'TRACE' then 1
        when 'INFO' then 1
        end = 1)
group by trim(substr(text, 25, 5))