# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER app
WORKDIR /app
EXPOSE 5000


# This stage is used to build the service project
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG TARGETARCH
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Directory.Build.props", "src/Directory.Build.props"]
COPY ["src/Api/ApiGrpcHttp2/ApiGrpcHttp2.csproj", "src/Api/ApiGrpcHttp2/"]
RUN dotnet restore "./src/Api/ApiGrpcHttp2/ApiGrpcHttp2.csproj" -a $TARGETARCH
COPY . .
WORKDIR "/src/src/Api/ApiGrpcHttp2"
RUN dotnet build "./ApiGrpcHttp2.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ApiGrpcHttp2.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false -a $TARGETARCH

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiGrpcHttp2.dll"]
