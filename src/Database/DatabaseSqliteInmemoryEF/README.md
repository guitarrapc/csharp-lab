Initialize with dotnet-ef
```bash
cd src/Database/DatabaseSqliteInmemoryEF

# only for once you created project
dotnet new tool-manifest
dotnet tool install dotnet-ef

# Create migration
dotnet ef migrations add InitialCreate
```
