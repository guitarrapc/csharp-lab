#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5094 5095 5096

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Api/ApiMultiplePort/ApiMultiplePort.csproj", "src/Api/ApiMultiplePort/"]
RUN dotnet restore "src/Api/ApiMultiplePort/ApiMultiplePort.csproj"
COPY . .
WORKDIR "/src/src/Api/ApiMultiplePort"
RUN dotnet build "ApiMultiplePort.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiMultiplePort.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiMultiplePort.dll"]
