Initialize with dotnet-ef
```bash
# launch database
docker compose up
cd src/Database/DatabaseMySqlEf

# only for once you created project
dotnet new tool-manifest
dotnet tool install dotnet-ef

# Create migration
dotnet ef migrations add InitialCreate

# Run migration
dotnet ef database update
```
