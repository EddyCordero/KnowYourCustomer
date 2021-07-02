
::# Getting Fluent Migrator CLI to Run Migrations
dotnet tool install -g FluentMigrator.DotNet.Cli --version 3.2.1

::# Update Fluent Migrator CLI
dotnet tool upgrade -g FluentMigrator.DotNet.Cli 

rem ::#Getting libman CLI for js package management
rem dotnet tool install -g Microsoft.Web.LibraryManager.Cli 

rem ::#Ignore changes made to the appsettings.Development.json file
rem git update-index --assume-unchanged Web/appsettings.Development.json

rem ::#Moves to web project
rem cd Web/
rem ::#Restore js dependencies
rem libman restore

cd ../Migrations
dotnet restore Migrations.csproj
dotnet build Migrations.csproj
dotnet fm migrate -p sqlite -c "Data Source=../mydb.db" -a "bin/Debug/netcoreapp3.1/Migrations.dll"

cd ../