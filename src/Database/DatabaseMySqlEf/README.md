Initialize with dotnet-ef
```bash
cd src/Database/DatbaseMySQLEf
dotnet new tool-manifest
dotnet tool install dotnet-ef

# Create migration
dotnet ef migrations add InitialCreate

# Run migration
dotnet ef database update
```
