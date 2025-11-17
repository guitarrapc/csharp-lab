#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 80

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG TARGETARCH
WORKDIR /src
COPY ["Directory.Packages.props", "."]
COPY ["Directory.Build.props", "."]
COPY ["src/MemoryLeak/MemoryLeakApi/MemoryLeakApi.csproj", "src/MemoryLeak/MemoryLeakApi/"]
COPY ["src/MemoryLeak/MemoryLeak.Core/MemoryLeak.Core.csproj", "src/MemoryLeak/MemoryLeak.Core/"]
RUN dotnet restore "src/MemoryLeak/MemoryLeakApi/MemoryLeakApi.csproj" -a $TARGETARCH
COPY . .
WORKDIR "/src/src/MemoryLeak/MemoryLeakApi"
RUN dotnet build "MemoryLeakApi.csproj" -c Release -o /app/build -a $TARGETARCH

FROM build AS publish
RUN dotnet publish "MemoryLeakApi.csproj" -c Release -o /app/publish /p:UseAppHost=false -a $TARGETARCH

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MemoryLeakApi.dll"]
