#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Logger/Logger.Benchmark/Logger.Benchmark.csproj", "src/Logger/Logger.Benchmark/"]
COPY ["src/Logger/LoggerDefault/LoggerDefault.csproj", "src/Logger/LoggerDefault/"]
RUN dotnet restore "src/Logger/Logger.Benchmark/Logger.Benchmark.csproj"
COPY . .
WORKDIR "/src/src/Logger/Logger.Benchmark"
RUN dotnet build "Logger.Benchmark.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Logger.Benchmark.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Logger.Benchmark.dll"]
