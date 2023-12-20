#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Logic/Logic.Benchmark/Logic.Benchmark.csproj", "src/Logic/Logic.Benchmark/"]
COPY ["src/Logic/Logic.Core/Logic.Core.csproj", "src/Logic/Logic.Core/"]
RUN dotnet restore "src/Logic/Logic.Benchmark/Logic.Benchmark.csproj"
COPY . .
WORKDIR "/src/src/Logic/Logic.Benchmark"
RUN dotnet build "Logic.Benchmark.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Logic.Benchmark.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Logic.Benchmark.dll"]
