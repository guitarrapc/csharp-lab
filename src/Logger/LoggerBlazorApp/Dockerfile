#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Logger/LoggerBlazorApp/LoggerBlazorApp.csproj", "src/Logger/LoggerBlazorApp/"]
RUN dotnet restore "src/Logger/LoggerBlazorApp/LoggerBlazorApp.csproj"
COPY . .
WORKDIR "/src/src/Logger/LoggerBlazorApp"
RUN dotnet build "LoggerBlazorApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LoggerBlazorApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LoggerBlazorApp.dll"]
