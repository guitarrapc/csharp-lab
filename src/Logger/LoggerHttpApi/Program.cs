var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ==== HttpLogging ====
{
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
}

// ==== ExceptionHandler ====
var enableSwagger = false;
{
    // enable swagger on ASPNETCORE_ENVIRONMENT = Production
    enableSwagger = !string.IsNullOrEmpty(builder.Configuration.GetValue<string>("ENABLE_SWAGGER"));
    builder.Services.AddProblemDetails(); // net7.0 and higher
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || enableSwagger)
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ==== HttpLogging ====
{
    // enable HttpLogging
    app.UseHttpLogging();

    var summaries = new[]
    {
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

    app.MapGet("/weatherforecast", (HttpContext context, ILoggerFactory loggerFactory) =>
    {
        // ==== HttpLogging ====
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
}

// ==== ExceptionHandler ====
{
    app.UseExceptionHandler(); // under UseHttpLogging() to show HttpLogging.
    app.MapGet("/throw", () =>
    {
        throw new InvalidOperationException();

        // `ASPNETCORE_ENVIRONMENT=Development` & No ExceptionHandler
        // Automatically add exception handler. No kestrel layer peneration. No HttpLogging Response log.
        /*
    info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[1]
          => SpanId:9e6570d96eb6fc5b, TraceId:5c492e5c8bdf4ae9becc0a829c663eaf, ParentId:0000000000000000 => ConnectionId:0HMSEQGA9IRPS => RequestPath:/throw RequestId:0HMSEQGA9IRPS:00000004
          Request:
          Protocol: HTTP/1.1
          Method: GET
          Scheme: http
          PathBase:
          Path: /throw
    fail: Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddleware[1]
          => SpanId:9e6570d96eb6fc5b, TraceId:5c492e5c8bdf4ae9becc0a829c663eaf, ParentId:0000000000000000 => ConnectionId:0HMSEQGA9IRPS => RequestPath:/throw RequestId:0HMSEQGA9IRPS:00000004
          An unhandled exception has occurred while executing the request.
          System.InvalidOperationException: Operation is not valid due to the current state of the object.
             at Program.<>c.<<Main>$>b__0_3() in D:\git\guitarrapc\csharp-lab\src\Logger\LoggerHttpApi\Program.cs:line 113
             at lambda_method3(Closure, Object, HttpContext)
             at Microsoft.AspNetCore.Routing.EndpointMiddleware.Invoke(HttpContext httpContext)
          --- End of stack trace from previous location ---
             at Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware.InvokeInternal(HttpContext context)
             at Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIMiddleware.Invoke(HttpContext httpContext)
             at Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware.Invoke(HttpContext httpContext, ISwaggerProvider swaggerProvider)
             at Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddlewareImpl.Invoke(HttpContext context)
         */

        // `ASPNETCORE_ENVIRONMENT=Production` & No ExceptionHandler
        // Never add exception handler automatically. Kestrel layer peneration is happen. No HttpLogging Response log.
        /*
    info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[1]
          => SpanId:d0fc731b6f66a639, TraceId:54c5610665d45bff838109579db0724c, ParentId:0000000000000000 => ConnectionId:0HMSEQIJLTCEH => RequestPath:/throw RequestId:0HMSEQIJLTCEH:00000003
          Request:
          Protocol: HTTP/1.1
          Method: GET
          Scheme: http
          PathBase:
          Path: /throw
    fail: Microsoft.AspNetCore.Server.Kestrel[13]
          => SpanId:d0fc731b6f66a639, TraceId:54c5610665d45bff838109579db0724c, ParentId:0000000000000000 => ConnectionId:0HMSEQIJLTCEH => RequestPath:/throw RequestId:0HMSEQIJLTCEH:00000003
          Connection id "0HMSEQIJLTCEH", Request id "0HMSEQIJLTCEH:00000003": An unhandled exception was thrown by the application.
          System.InvalidOperationException: Operation is not valid due to the current state of the object.
             at Program.<>c.<<Main>$>b__0_3() in D:\git\guitarrapc\csharp-lab\src\Logger\LoggerHttpApi\Program.cs:line 122
             at lambda_method3(Closure, Object, HttpContext)
             at Microsoft.AspNetCore.Routing.EndpointMiddleware.Invoke(HttpContext httpContext)
          --- End of stack trace from previous location ---
             at Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware.InvokeInternal(HttpContext context)
             at Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIMiddleware.Invoke(HttpContext httpContext)
             at Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware.Invoke(HttpContext httpContext, ISwaggerProvider swaggerProvider)
             at Microsoft.AspNetCore.Watch.BrowserRefresh.BrowserRefreshMiddleware.InvokeAsync(HttpContext context)
             at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application) // <-- Kestrel Layer!!
         */

        // ==Add ExceptionHandler=====================================================================

        // `ASPNETCORE_ENVIRONMENT=Development` & ExceptionHandler
        // Add exception handler manually. No kestrel layer peneration. HttpLogging Response log after throw.
        /*
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[1]
      => SpanId:a224a85658ae6295, TraceId:7d590d8750ad5833c325cf85ef019c5e, ParentId:0000000000000000 => ConnectionId:0HMSEQL60GH8F => RequestPath:/throw RequestId:0HMSEQL60GH8F:00000003
      Request:
      Protocol: HTTP/1.1
      Method: GET
      Scheme: http
      PathBase:
      Path: /throw
fail: Microsoft.AspNetCore.Diagnostics.ExceptionHandlerMiddleware[1]
      => SpanId:a224a85658ae6295, TraceId:7d590d8750ad5833c325cf85ef019c5e, ParentId:0000000000000000 => ConnectionId:0HMSEQL60GH8F => RequestPath:/throw RequestId:0HMSEQL60GH8F:00000003
      An unhandled exception has occurred while executing the request.
      System.InvalidOperationException: Operation is not valid due to the current state of the object.
         at Program.<>c.<<Main>$>b__0_2() in D:\git\guitarrapc\csharp-lab\src\Logger\LoggerHttpApi\Program.cs:line 131
         at lambda_method3(Closure, Object, HttpContext)
         at Microsoft.AspNetCore.Routing.EndpointMiddleware.Invoke(HttpContext httpContext)
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Diagnostics.ExceptionHandlerMiddlewareImpl.<Invoke>g__Awaited|8_0(ExceptionHandlerMiddlewareImpl middleware, HttpContext context, Task task)
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[2]
      => SpanId:a224a85658ae6295, TraceId:7d590d8750ad5833c325cf85ef019c5e, ParentId:0000000000000000 => ConnectionId:0HMSEQL60GH8F => RequestPath:/throw RequestId:0HMSEQL60GH8F:00000003
      Response:
      StatusCode: 500
         */

        // `ASPNETCORE_ENVIRONMENT=Production` & ExceptionHandler
        // Add exception handler manually. Kestrel layer peneration is happen. HttpLogging Response log after throw.
        /*
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[1]
      => SpanId:e2b55dac49d255c7, TraceId:6dccebb15f4437a6138c8657eda75020, ParentId:0000000000000000 => ConnectionId:0HMSEQMDV03QM => RequestPath:/throw RequestId:0HMSEQMDV03QM:00000003
      Request:
      Protocol: HTTP/1.1
      Method: GET
      Scheme: http
      PathBase:
      Path: /throw
fail: Microsoft.AspNetCore.Diagnostics.ExceptionHandlerMiddleware[1]
      => SpanId:e2b55dac49d255c7, TraceId:6dccebb15f4437a6138c8657eda75020, ParentId:0000000000000000 => ConnectionId:0HMSEQMDV03QM => RequestPath:/throw RequestId:0HMSEQMDV03QM:00000003
      An unhandled exception has occurred while executing the request.
      System.InvalidOperationException: Operation is not valid due to the current state of the object.
         at Program.<>c.<<Main>$>b__0_2() in D:\git\guitarrapc\csharp-lab\src\Logger\LoggerHttpApi\Program.cs:line 131
         at lambda_method3(Closure, Object, HttpContext)
         at Microsoft.AspNetCore.Routing.EndpointMiddleware.Invoke(HttpContext httpContext)
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Diagnostics.ExceptionHandlerMiddlewareImpl.<Invoke>g__Awaited|8_0(ExceptionHandlerMiddlewareImpl middleware, HttpContext context, Task task)
info: Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware[2]
      => SpanId:e2b55dac49d255c7, TraceId:6dccebb15f4437a6138c8657eda75020, ParentId:0000000000000000 => ConnectionId:0HMSEQMDV03QM => RequestPath:/throw RequestId:0HMSEQMDV03QM:00000003
      Response:
      StatusCode: 500
         */
    })
    .WithName("Throw");
}

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
