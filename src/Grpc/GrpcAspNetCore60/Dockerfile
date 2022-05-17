#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Grpc/GrpcAspNetCore60/GrpcAspNetCore60.csproj", "src/Grpc/GrpcAspNetCore60/"]
RUN dotnet restore "src/Grpc/GrpcAspNetCore60/GrpcAspNetCore60.csproj"
COPY . .
WORKDIR "/src/src/Grpc/GrpcAspNetCore60"
RUN dotnet build "GrpcAspNetCore60.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GrpcAspNetCore60.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GrpcAspNetCore60.dll"]