#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM nginx:1.21.6 AS base
WORKDIR /usr/share/nginx/html
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Blazor/BlazorWasmAotApp/BlazorWasmAotApp.csproj", "src/Blazor/BlazorWasmAotApp/"]
RUN set -x \
    && apt-get update && apt-get install -y python3 --no-install-recommends \
    && dotnet workload restore "src/Blazor/BlazorWasmAotApp/BlazorWasmAotApp.csproj"
RUN dotnet restore "src/Blazor/BlazorWasmAotApp/BlazorWasmAotApp.csproj"
COPY . .
WORKDIR "/src/src/Blazor/BlazorWasmAotApp"
RUN dotnet build "BlazorWasmAotApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorWasmAotApp.csproj" -c Release -o /app/publish

FROM base AS final
COPY --from=publish /app/publish/wwwroot .
# COPY ["src/Blazor/BlazorWasmAotApp/nginx.conf", "/etc/nginx/nginx.conf"]
