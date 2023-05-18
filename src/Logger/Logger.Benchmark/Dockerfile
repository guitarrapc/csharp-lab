#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Logger/LoggerBenchmark/LoggerBenchmark.csproj", "src/Logger/LoggerBenchmark/"]
COPY ["src/Logger/LoggerDefault/LoggerDefault.csproj", "src/Logger/LoggerDefault/"]
RUN dotnet restore "src/Logger/LoggerBenchmark/LoggerBenchmark.csproj"
COPY . .
WORKDIR "/src/src/Logger/LoggerBenchmark"
RUN dotnet build "LoggerBenchmark.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LoggerBenchmark.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LoggerBenchmark.dll"]