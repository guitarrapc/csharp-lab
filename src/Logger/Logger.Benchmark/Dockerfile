# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER app
WORKDIR /app


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY --from=mcr.microsoft.com/dotnet/sdk:8.0 /usr/share/dotnet/sdk /usr/share/dotnet/sdk
COPY ["Directory.Build.props", "src/Directory.Build.props"]
COPY ["src/Logger/Logger.Benchmark/Logger.Benchmark.csproj", "src/Logger/Logger.Benchmark/"]
COPY ["src/Logger/LoggerDefault/LoggerDefault.csproj", "src/Logger/LoggerDefault/"]
RUN dotnet restore "./src/Logger/Logger.Benchmark/Logger.Benchmark.csproj"
COPY . .
WORKDIR "/src/src/Logger/Logger.Benchmark"
RUN dotnet build "./Logger.Benchmark.csproj" -c $BUILD_CONFIGURATION -o /app/build -f net9.0

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Logger.Benchmark.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false -f net9.0

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Logger.Benchmark.dll"]
