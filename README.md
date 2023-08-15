[![Benchmarker](https://github.com/guitarrapc/csharp-lab/actions/workflows/benchmarker.yaml/badge.svg)](https://github.com/guitarrapc/csharp-lab/actions/workflows/benchmarker.yaml)
[![Build Docker](https://github.com/guitarrapc/csharp-lab/actions/workflows/build-docker.yaml/badge.svg)](https://github.com/guitarrapc/csharp-lab/actions/workflows/build-docker.yaml)
[![Build Dotnet](https://github.com/guitarrapc/csharp-lab/actions/workflows/build-dotnet.yaml/badge.svg)](https://github.com/guitarrapc/csharp-lab/actions/workflows/build-dotnet.yaml)
[![Lint Dotnet](https://github.com/guitarrapc/csharp-lab/actions/workflows/lint-dotnet.yaml/badge.svg)](https://github.com/guitarrapc/csharp-lab/actions/workflows/lint-dotnet.yaml)

[![Docker Pulls](https://img.shields.io/docker/pulls/guitarrapc/csharp-lab.svg?style=for-the-badge)](https://hub.docker.com/r/guitarrapc/csharp-lab/)

# csharp-lab


# Getting started

## Prerequisites

* Install .NET SDK 6 and 7.
* Install wasm-tools-net6.

```sh
dotnet workload install wasm-tools-net6
```

# Container Debugging

## Attach Visual Studio 2022 to Linux Docker Container

Run your .NET Application inside Docker container. Let's run Linux Docker on Windows.

```
$ docker build -t blazorserverapp:dev -f src/Blazor/BlazorServerApp/Dockerfile .
$ docker run -p 8080:80 blazorserverapp:dev
warn: Microsoft.AspNetCore.DataProtection.Repositories.FileSystemXmlRepository[60]
      Storing keys in a directory '/root/.aspnet/DataProtection-Keys' that may not be persisted outside of the container. Protected data will be unavailable when container is destroyed.
warn: Microsoft.AspNetCore.DataProtection.KeyManagement.XmlKeyManager[35]
      No XML encryptor configured. Key {98540753-27a5-40cd-8c8c-1a36659ae48f} may be persisted to storage in unencrypted form.
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://[::]:80
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
info: Microsoft.Hosting.Lifetime[0]
      Content root path: /app/

$ docker ps
CONTAINER ID   IMAGE                 COMMAND                   CREATED         STATUS         PORTS                  NAMES
d1059e5349f3   blazorserverapp:dev   "dotnet BlazorServer…"   4 seconds ago   Up 3 seconds   0.0.0.0:8080->80/tcp   jolly_kare
```

Open Visual Studio. Go to `Debug > Attach to process`.

![image](https://user-images.githubusercontent.com/3856350/256191790-e0e955f8-b2ab-4d21-b1f8-78c8d623d364.png)

Select `Connection type:` to `Docker (Linux Container)`.

![image](https://user-images.githubusercontent.com/3856350/256192053-62eb22bb-8c76-4b17-8c8a-66bcdd6c6832.png)

Select `Find`, Docker CLI host is `Local Machine`. Now your docker container is listed.

![image](https://user-images.githubusercontent.com/3856350/256195607-218e8e99-2dd3-44d5-9605-3a871e4b6756.png)

Select container and `OK`, then `Attach`.

![image](https://user-images.githubusercontent.com/3856350/256195734-4fff6d52-64cb-4faf-ac94-5833c985fe87.png)

Select `Debug these code types` to `Managed (.NET Core for Unix)`, then `OK`.

![image](https://user-images.githubusercontent.com/3856350/256195982-f34dabce-1c31-4100-8700-9dde26a6690d.png)

![image](https://user-images.githubusercontent.com/3856350/256193043-35ac7c94-2dc6-4b04-813e-a11372e095ed.png)

Because Linux Docker source is differ from Windows source, you need to allow debugging source from different location.
set `Debugg Point` and open `Settings`, enable `Allow the source files to be different from origina`.

![image](https://user-images.githubusercontent.com/3856350/256196212-d682bf4a-0abe-44c7-92c8-97541fc79176.png)
![image](https://user-images.githubusercontent.com/3856350/256196322-231ec010-220d-4688-bb47-c36eabbd3f64.png)

Set debugger point and open `http://localhost:8080/counter`, click `Increment` button. Debugger stops at your point.

![image](https://user-images.githubusercontent.com/3856350/256196434-e6004da9-e561-4a49-8e0d-4973d965943b.png)
![image](https://user-images.githubusercontent.com/3856350/256196461-4e5b8bd2-e8f7-454d-a5cd-bb40d4894df7.png)


## Attach Visual Studio 2022 to Linux Kubernetes Pod

https://learn.microsoft.com/en-us/visualstudio/bridge/bridge-to-kubernetes-vs & https://marketplace.visualstudio.com/items?itemName=ms-azuretools.mindaro2022

note: https://itnext.io/how-to-debug-asp-net-core-in-kubernetes-from-visual-studio-2019-1e9d16099d99
