#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Grpc/AspNetCore60.HealthCheckSupport/AspNetCore60.HealthCheckSupport.csproj", "src/Grpc/AspNetCore60.HealthCheckSupport/"]
RUN dotnet restore "src/Grpc/AspNetCore60.HealthCheckSupport/AspNetCore60.HealthCheckSupport.csproj"
COPY . .
WORKDIR "/src/src/Grpc/AspNetCore60.HealthCheckSupport"
RUN dotnet build "AspNetCore60.HealthCheckSupport.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AspNetCore60.HealthCheckSupport.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AspNetCore60.HealthCheckSupport.dll"]