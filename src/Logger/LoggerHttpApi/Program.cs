var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// see: https://speakerdeck.com/nenonaninu/ming-ri-karashi-eru-asp-dot-net-core-rogingushu
// Add HttpLogging. It adds Http Request/Response logging.
builder.Services.AddHttpLogging(options =>
{
    // Add field by bit operator
    options.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.RequestProperties | Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.ResponseStatusCode;
});
/*
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[1]
      Request:
      Protocol: HTTP/1.1
      Method: GET
      Scheme: http
      PathBase:
      Path: /weatherforecast
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[2]
      Response:
      StatusCode: 200
 */

// Add Scope to Logging. It adds SpanId, TraceId, ParentId to log.
builder.Logging.AddSimpleConsole(options =>
{
    options.IncludeScopes = true;
});
// if JSON Logger is needed.
//builder.Logging.AddJsonConsole(options =>
//{
//    options.IncludeScopes = true;
//    options.UseUtcTimestamp = true;
//});
/*
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[1]
      => SpanId:b3fc14d154aca000, TraceId:431e58214492c9013b5d751c4cc87a7d, ParentId:0000000000000000 => ConnectionId:0HMSEQ25QPDS5 => RequestPath:/weatherforecast RequestId:0HMSEQ25QPDS5:00000004
      Request:
      Protocol: HTTP/1.1
      Method: GET
      Scheme: http
      PathBase:
      Path: /weatherforecast
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[2]
      => SpanId:b3fc14d154aca000, TraceId:431e58214492c9013b5d751c4cc87a7d, ParentId:0000000000000000 => ConnectionId:0HMSEQ25QPDS5 => RequestPath:/weatherforecast RequestId:0HMSEQ25QPDS5:00000004
      Response:
      StatusCode: 200
 */

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// enable HttpLogging
app.UseHttpLogging();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", (HttpContext context, ILoggerFactory loggerFactory) =>
{
    var logger = loggerFactory.CreateLogger("weatherforecast");
    logger.LogInformation("foo");
    using var scope = logger.BeginScope("MyScope");
    logger.LogInformation("bar");

    /*
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[1]
      => SpanId:5848a789f256127a, TraceId:e853dfcd9bd5f6513c0fdd735d0fd6ab, ParentId:0000000000000000 => ConnectionId:0HMSEQ4NCRPN7 => RequestPath:/weatherforecast RequestId:0HMSEQ4NCRPN7:00000005
      Request:
      Protocol: HTTP/1.1
      Method: GET
      Scheme: http
      PathBase:
      Path: /weatherforecast
info: weatherforecast[0]
      => SpanId:5848a789f256127a, TraceId:e853dfcd9bd5f6513c0fdd735d0fd6ab, ParentId:0000000000000000 => ConnectionId:0HMSEQ4NCRPN7 => RequestPath:/weatherforecast RequestId:0HMSEQ4NCRPN7:00000005
      foo
info: weatherforecast[0]
      => SpanId:5848a789f256127a, TraceId:e853dfcd9bd5f6513c0fdd735d0fd6ab, ParentId:0000000000000000 => ConnectionId:0HMSEQ4NCRPN7 => RequestPath:/weatherforecast RequestId:0HMSEQ4NCRPN7:00000005 => MyScope
      bar
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[2]
      => SpanId:5848a789f256127a, TraceId:e853dfcd9bd5f6513c0fdd735d0fd6ab, ParentId:0000000000000000 => ConnectionId:0HMSEQ4NCRPN7 => RequestPath:/weatherforecast RequestId:0HMSEQ4NCRPN7:00000005
      Response:
      StatusCode: 200
     */

    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
