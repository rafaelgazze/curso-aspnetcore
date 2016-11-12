USE [master] 
RESTORE DATABASE [AdventureWorks2014] 
FROM DISK = N'$(path)\AdvWorks.bak' WITH FILE = 1, 
MOVE N'AdventureWorks2014_Data' TO N'$(path)\AdvWorks.mdf', 
MOVE N'AdventureWorks2014_Log' TO N'$(path)\AdvWorks_Log.ldf', NOUNLOAD,  REPLACE,  STATS = 5 
GO


