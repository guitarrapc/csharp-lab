#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/MemoryLeak/MemoryLeak.Benchmark/MemoryLeak.Benchmark.csproj", "src/MemoryLeak/MemoryLeak.Benchmark/"]
COPY ["src/MemoryLeak/MemoryLeak.Core/MemoryLeak.Core.csproj", "src/MemoryLeak/MemoryLeak.Core/"]
RUN dotnet restore "src/MemoryLeak/MemoryLeak.Benchmark/MemoryLeak.Benchmark.csproj"
COPY . .
WORKDIR "/src/src/MemoryLeak/MemoryLeak.Benchmark"
RUN dotnet build "MemoryLeak.Benchmark.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MemoryLeak.Benchmark.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MemoryLeak.Benchmark.dll"]