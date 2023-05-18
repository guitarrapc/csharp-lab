#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Logic/LogicLab.Benchmark/LogicLab.Benchmark.csproj", "src/Logic/LogicLab.Benchmark/"]
COPY ["src/Logic/LogicLab/LogicLab.csproj", "src/Logic/LogicLab/"]
RUN dotnet restore "src/Logic/LogicLab.Benchmark/LogicLab.Benchmark.csproj"
COPY . .
WORKDIR "/src/src/Logic/LogicLab.Benchmark"
RUN dotnet build "LogicLab.Benchmark.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LogicLab.Benchmark.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LogicLab.Benchmark.dll"]