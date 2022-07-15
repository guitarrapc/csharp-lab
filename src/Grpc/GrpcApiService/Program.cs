using GrpcApiService.Services;

// $ curl -X 'GET' 'http://localhost:5094/HttpApi'
// $ grpcurl --plaintext localhost:5095 list
// $ grpcurl --plaintext -d "{\"name\":\"foo\"}" localhost:5095 greet.Greeter/SayHello

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add Web API Controller
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.AddGrpc();

// Allow reflection for grpcurl
// builder.Services.AddGrpcReflection();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    //app.MapGrpcReflectionService();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>(); // grpc
app.MapGrpcService<DuplexerService>(); // grpc
app.MapControllers(); // api controller
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
