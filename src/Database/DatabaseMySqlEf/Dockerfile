# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/runtime:10.0 AS base
USER $APP_UID
WORKDIR /app


# This stage is used to build the service project
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG TARGETARCH
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Directory.Packages.props", "."]
COPY ["Directory.Build.props", "."]
COPY ["src/Database/DatabaseMySqlEf/DatabaseMySqlEf.csproj", "src/Database/DatabaseMySqlEf/"]
COPY ["src/Database/DatabaseCore/DatabaseCore.csproj", "src/Database/DatabaseCore/"]
RUN dotnet restore "./src/Database/DatabaseMySqlEf/DatabaseMySqlEf.csproj" -a $TARGETARCH
COPY . .
WORKDIR "/src/src/Database/DatabaseMySqlEf"
RUN dotnet build "./DatabaseMySqlEf.csproj" -c $BUILD_CONFIGURATION -o /app/build -a $TARGETARCH

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./DatabaseMySqlEf.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false -a $TARGETARCH

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DatabaseMySqlEf.dll"]
