# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER app
WORKDIR /app


# This stage is used to build the service project
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG TARGETARCH
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Directory.Build.props", "src/Directory.Build.props"]
COPY ["src/SystemInfo/SystemInfo.Sandbox/SystemInfo.Sandbox.csproj", "src/SystemInfo/SystemInfo.Sandbox/"]
COPY ["src/SystemInfo/SystemInfo.Core/SystemInfo.Core.csproj", "src/SystemInfo/SystemInfo.Core/"]
RUN dotnet restore "./src/SystemInfo/SystemInfo.Sandbox/SystemInfo.Sandbox.csproj" -a $TARGETARCH
COPY . .
WORKDIR "/src/src/SystemInfo/SystemInfo.Sandbox"
RUN dotnet build "./SystemInfo.Sandbox.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SystemInfo.Sandbox.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false -a $TARGETARCH

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SystemInfo.Sandbox.dll"]
