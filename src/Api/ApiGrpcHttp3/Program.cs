using Api.Shared.GrpcShared.Infrastructures;
using Api.Shared.GrpcShared.Services;
using Microsoft.Extensions.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

// Add gRPC Health Check. Need AddCheck("Sample") to respond.
// $ grpcurl -plaintext localhost:5000 grpc.health.v1.Health.Check
// $ grpc_health_probe --addr=127.0.0.1:5000
builder.Services.AddGrpcHealthChecks().AddCheck("Sample", () => HealthCheckResult.Healthy());

// Allow reflection for grpcurl
// $ grpcurl -plaintext 127.0.0.1:5000 list
// $ grpcurl -plaintext 127.0.0.1:5000 list greet.Greeter
// $ grpcurl -plaintext 127.0.0.1:5000 greet.Greeter.SayHello
// $ grpcurl -plaintext -proto ./src/Api/Api.Shared/Protos/greet.proto -d "{\"name\": \"foo\"}" 127.0.0.1:5000 greet.Greeter/SayHello
// $ grpcurl -plaintext -proto ./src/Api/Api.Shared/Protos/duplexer.proto -d "{\"name\": \"foo\"}{\"name\": \"bar\"}{\"name\": \"piyo\"}" 127.0.0.1:5000 duplexer.Duplexer/Echo
builder.Services.AddGrpcReflection();

// Enable HTTP/3
builder.ConfigureHttp3Endpoint()
    .EnableSelfcheck(options =>
    {
        options.BaseAddress = new Uri("https://localhost:5001");
        options.UseHttp3 = true;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapGrpcReflectionService();
}

app.UseHttpsRedirection();

app.MapGrpcService<GreeterService>();
app.MapGrpcService<DuplexerService>();
app.MapGrpcHealthChecksService();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
