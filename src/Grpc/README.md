gRPC in 1 minutes (C#)
========================

## GrpcAspNetCore60

ASP.NET Core Grpc minimum implementation in .NET 6.0

> see: https://docs.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start?view=aspnetcore-6.0&tabs=visual-studio

```shell
$ grpcurl --plaintext -proto ./src/Grpc/GrpcAspNetCore60/Protos/greet.proto -d "{\"name\": \"foo\"}" localhost:5095 greet.Greeter/SayHello
{
  "message": "Hello foo"
}
```

## GrpcAspNetCore60.HealthCheckSupport

ASP.NET Core Grpc .NET 6.0 with Health Probe.

> see: https://docs.microsoft.com/en-us/aspnet/core/grpc/health-checks?view=aspnetcore-6.0

```shell
$ docker run -d -n aspnetcoregrpc -p 7018:80 guitarrapc/csharp-lab:latest-grpc-aspnetcore60.healthchecksupport
$ grpc_health_probe -addr=localhost:7018
status: SERVING
$ grpcurl -plaintext -proto health.proto localhost:7018 grpc.health.v1.Health/Check
{
  "status": "SERVING"
}
$ docker kill aspnetcoregrpc
```


## GrpcAspNetCoreWithApi

ASP.NET Cor eGrpc .NET 6.0 with API Controller.

```shell
# unary
$ grpcurl --plaintext -proto ./src/Grpc/GrpcApiService/Protos/greet.proto -d "{\"name\": \"foo\"}" localhost:5095 greet.Greeter/SayHello
{
  "message": "Hello foo"
}

# bidirectional
$ grpcurl --plaintext -proto ./src/Grpc/GrpcApiService/Protos/duplexer.proto -d "{\"name\": \"foo\"}{\"name\": \"bar\"}{\"name\": \"piyo\"}" localhost:5095 duplexer.Duplexer/Echo
{
  "message": "foo"
}
{
  "message": "bar"
}
{
  "message": "piyo"
}
```

You can use C# Grpc Clinet to connect.

```
$ cd src/Grpc/GrpcApiService/Client
$ dotnet run Greeter --name "foo"
$ dotnet run Duplexer --names "foo bar piyo end"
```
