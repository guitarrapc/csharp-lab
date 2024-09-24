# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
# add libmsquic
RUN set -ex \
    && apt-get update \
    && apt-get install -y curl gnupg apt-transport-https \
    && apt-get clean && rm -rf /var/lib/apt/lists/*
RUN set -ex \
    && . /etc/os-release \
    && curl -sSL -o /tmp/packages-microsoft-prod.deb https://packages.microsoft.com/config/$ID/$VERSION_ID/packages-microsoft-prod.deb \
    && dpkg -i /tmp/packages-microsoft-prod.deb \
    && rm -f /tmp/packages-microsoft-prod.deb \
    && apt-get update
RUN set -ex \
    && apt-get install -y libmsquic \
    && apt-get clean && rm -rf /var/lib/apt/lists/*

USER app
WORKDIR /app
EXPOSE 5001

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Api/ApiHttp3/ApiHttp3.csproj", "src/Api/ApiHttp3/"]
RUN dotnet restore "./src/Api/ApiHttp3/ApiHttp3.csproj"
COPY . .
WORKDIR "/src/src/Api/ApiHttp3"
RUN dotnet build "./ApiHttp3.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ApiHttp3.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiHttp3.dll"]
