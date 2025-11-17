# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
# add libmsquic see: https://learn.microsoft.com/en-us/linux/packages & https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/http3?view=aspnetcore-8.0
RUN set -ex \
    && . /etc/os-release \
    && apt-get update \
    && apt-get install -y wget --no-install-recommends \
    && wget https://packages.microsoft.com/config/$ID/$VERSION_ID/packages-microsoft-prod.deb -O /tmp/packages-microsoft-prod.deb \
    && dpkg -i /tmp/packages-microsoft-prod.deb \
    && rm -f /tmp/packages-microsoft-prod.deb \
    && apt-get update \
    && apt-get install -y libmsquic --no-install-recommends \
    && apt-get clean && rm -rf /var/lib/apt/lists/*
USER $APP_UID
WORKDIR /app
EXPOSE 5001


# This stage is used to build the service project
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG TARGETARCH
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Directory.Packages.props", "."]
COPY ["Directory.Build.props", "."]
COPY ["src/Api/ApiHttp3/ApiHttp3.csproj", "src/Api/ApiHttp3/"]
RUN dotnet restore "./src/Api/ApiHttp3/ApiHttp3.csproj" -a $TARGETARCH
COPY . .
WORKDIR "/src/src/Api/ApiHttp3"
RUN dotnet build "./ApiHttp3.csproj" -c $BUILD_CONFIGURATION -o /app/build -a $TARGETARCH

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ApiHttp3.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false -a $TARGETARCH

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiHttp3.dll"]
