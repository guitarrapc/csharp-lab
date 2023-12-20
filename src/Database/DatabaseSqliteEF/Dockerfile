#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Database/DatabaseSqliteEF/DatabaseSqliteEf.csproj", "src/Database/DatabaseSqliteEF/"]
COPY ["src/Database/DatabaseCore/DatabaseCore.csproj", "src/Database/DatabaseCore/"]
RUN dotnet restore "src/Database/DatabaseSqliteEF/DatabaseSqliteEf.csproj"
COPY . .
WORKDIR "/src/src/Database/DatabaseSqliteEF"
RUN dotnet build "DatabaseSqliteEf.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DatabaseSqliteEf.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DatabaseSqliteEf.dll"]
