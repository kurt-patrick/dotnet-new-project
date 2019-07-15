REM create dll project
dotnet new classlib --name TheDll --framework netcoreapp2.2
cd TheDll
dotnet restore
dotnet build
cd..

REM create xunit test project
dotnet new xunit --name TheTests --framework netcoreapp2.2
dotnet add TheTests/TheTests.csproj reference TheDll/TheDll.csproj
cd TheTests
dotnet add package Newtonsoft.Json
dotnet restore
dotnet build
dotnet test

REM all done back to root folder
cd ..
