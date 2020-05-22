# Get started

## Prerequisites

- Windows operating system
- C# .NET Framework latest
- Database server (MySQL, MSSQL or Access)

## Install

Get the source code and the SQL script

```sh
sudo git clone https://github.com/arthuRHD/AppliGSB.git
```

## Config

Install the database on your network (here is an example with MySQL)

```sql
# Database
create mydatabase;
use mydatabase;
source [...]/GSB_visites/db_gsb.sql;

# User
create user 'myadmin'@'%' identified by 'mypassword';
grant all privileges on mydatabase.* to 'myadmin'@'%' identified by 'mypassword';
flush privileges;
```

Change the connexion string inside `GSB_visites/Program.cs`

```cs
// MySQL
string dbtype = "mysql";
string chaineConnexion = "Server=myhost;Database=mydatabase;Uid=myadmin;Pwd=secret;SslMode=none;";
// MSSQL
string dbtype = "sqlserver";
string chaineConnexion = "Data Source=myhost;Integrated Security=True;Pooling=False;Encrypt=False;";
// Access
string dbtype = "access";
string chaineConnexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccessFile.accdb;Persist Security Info=False;"
```

Build the application (CLI)

```sh
dotnet build GSB_visites.csproj -t:Clean -p:Configuration=Release;TargetFrameworkVersion=v4.7
```

Launch the executable in `GSB_visites/bin/Release/GSB_visites.exe`
