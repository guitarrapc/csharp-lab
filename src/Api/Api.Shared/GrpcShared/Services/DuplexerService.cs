using Grpc.Core;
using Microsoft.AspNetCore.Connections;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using Microsoft.Extensions.Logging;
#pragma warning restore IDE0005 // Using directive is unnecessary.

namespace Api.Shared.GrpcShared.Services;

public class DuplexerService(ILogger<DuplexerService> logger) : Duplexer.DuplexerBase
{
    public override async Task Echo(IAsyncStreamReader<BidiHelloRequest> requestStream, IServerStreamWriter<BidiHelloReply> responseStream, ServerCallContext context)
    {
        var reader = requestStream;
        var writer = responseStream;
        try
        {
            var ct = context.CancellationToken;
            while (await reader.MoveNext(ct))
            {
                var data = reader.Current;
                var name = data.Name;

                logger.LogInformation($"({nameof(Echo)}) Recieved request: {name}");
                if (string.Equals(name, "end", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                logger.LogInformation($"({nameof(Echo)}) Writing echo to Server Streaming: {name}");
                await writer.WriteAsync(new BidiHelloReply
                {
                    Message = $"Echo: {name}",
                }, ct);

                await Task.Delay(300, ct);
            }
        }
        catch (OperationCanceledException)
        {
            // suppress for client cancellation exception.
        }
        catch (IOException ex) when (ex.InnerException is ConnectionAbortedException)
        {
            // suppress for client cut off connection.
        }
        catch (Exception ex) when (ex.Message == "The client reset the request stream.")
        {
            // suppress for client cut off connection.
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            logger.LogDebug("Client Disconnected");
        }
    }
}
