using Grpc.Core;

#pragma warning disable IDE0005 // Using directive is unnecessary.
using Microsoft.Extensions.Logging;
#pragma warning restore IDE0005 // Using directive is unnecessary.

namespace Api.Shared.GrpcShared.Services;
public class GreeterService(ILogger<GreeterService> logger) : Greeter.GreeterBase
{
    public override async Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        logger.LogInformation($"Grpc Unary request accepted {request.Name}");
        return new HelloReply
        {
            Message = "Hello " + request.Name
        };
    }
}
