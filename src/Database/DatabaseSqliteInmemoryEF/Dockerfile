#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Database/DatabaseSqliteInmemoryEF/DatabaseSqliteInmemoryEF.csproj", "src/Database/DatabaseSqliteInmemoryEF/"]
COPY ["src/Database/DatabaseCore/DatabaseCore.csproj", "src/Database/DatabaseCore/"]
RUN dotnet restore "src/Database/DatabaseSqliteInmemoryEF/DatabaseSqliteInmemoryEF.csproj"
COPY . .
WORKDIR "/src/src/Database/DatabaseSqliteInmemoryEF"
RUN dotnet build "DatabaseSqliteInmemoryEF.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DatabaseSqliteInmemoryEF.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DatabaseSqliteInmemoryEF.dll"]
