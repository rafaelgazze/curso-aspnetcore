$path="path=$pwd"
Invoke-Sqlcmd -Variable $path -ServerInstance "(localdb)\mssqllocaldb" -InputFile .\AdvWorksRestore.sql 