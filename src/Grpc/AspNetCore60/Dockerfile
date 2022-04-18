#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AspNetCore60/AspNetCore60.csproj", "AspNetCore60/"]
RUN dotnet restore "AspNetCore60/AspNetCore60.csproj"
COPY . .
WORKDIR "/src/AspNetCore60"
RUN dotnet build "AspNetCore60.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AspNetCore60.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AspNetCore60.dll"]
