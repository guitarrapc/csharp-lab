Initialize with dotnet-ef
```bash
cd src/Database/DatbaseMySQLEf
dotnet new tool-manifest
dotnet tool install dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update
```
