gRPC in 1 minutes (C#)
========================

## AspNetCore60

ASP.NET Core Grpc minimum implementation in .NET 6.0

> see: https://docs.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start?view=aspnetcore-6.0&tabs=visual-studio

## AspNetCore60.HealthCheckSupport

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
