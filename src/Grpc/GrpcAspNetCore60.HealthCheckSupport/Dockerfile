#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Grpc/GrpcAspNetCore60.HealthCheckSupport/GrpcAspNetCore60.HealthCheckSupport.csproj", "src/Grpc/GrpcAspNetCore60.HealthCheckSupport/"]
RUN dotnet restore "src/Grpc/GrpcAspNetCore60.HealthCheckSupport/GrpcAspNetCore60.HealthCheckSupport.csproj"
COPY . .
WORKDIR "/src/src/Grpc/GrpcAspNetCore60.HealthCheckSupport"
RUN dotnet build "GrpcAspNetCore60.HealthCheckSupport.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GrpcAspNetCore60.HealthCheckSupport.csproj" -c Release -o /app/publish

FROM build as installer
RUN GRPC_HEALTH_PROBE_VERSION=v0.4.6 && \
    curl -L https://github.com/grpc-ecosystem/grpc-health-probe/releases/download/${GRPC_HEALTH_PROBE_VERSION}/grpc_health_probe-linux-amd64 -o /bin/grpc_health_probe && \
    chmod +x /bin/grpc_health_probe

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=installer [ "/bin/grpc_health_probe", "/bin/grpc_health_probe"]
ENTRYPOINT ["dotnet", "GrpcAspNetCore60.HealthCheckSupport.dll"]
