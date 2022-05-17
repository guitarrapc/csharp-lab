#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM amd64/buildpack-deps:buster-curl as installer
RUN GRPC_HEALTH_PROBE_VERSION=v0.4.6 && \
    curl -L https://github.com/grpc-ecosystem/grpc-health-probe/releases/download/${GRPC_HEALTH_PROBE_VERSION}/grpc_health_probe-linux-amd64 -o /bin/grpc_health_probe && \
    chmod +x /bin/grpc_health_probe

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
COPY --from=installer [ "/bin/grpc_health_probe", "/bin/grpc_health_probe"]
ENTRYPOINT ["dotnet", "AspNetCore60.HealthCheckSupport.dll"]
