using Grpc.Core;
using Microsoft.AspNetCore.Connections;

namespace GrpcApiService.Services;

public class DuplexerService : Duplexer.DuplexerBase
{
    private readonly ILogger<DuplexerService> _logger;
    public DuplexerService(ILogger<DuplexerService> logger)
    {
        _logger = logger;
    }

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

                _logger.LogInformation($"({nameof(Echo)}) Recieved request: {name}");
                if (string.Equals(name, "end", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                _logger.LogInformation($"({nameof(Echo)}) Writing echo to Server Streaming: {name}");
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
            _logger.LogInformation("Client Disconnected");
        }
    }
}
