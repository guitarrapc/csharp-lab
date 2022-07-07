#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5094 5095

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Grpc/GrpcApiService/GrpcApiService.csproj", "src/Grpc/GrpcApiService/"]
RUN dotnet restore "src/Grpc/GrpcApiService/GrpcApiService.csproj"
COPY . .
WORKDIR "/src/src/Grpc/GrpcApiService"
RUN dotnet build "GrpcApiService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GrpcApiService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GrpcApiService.dll"]
