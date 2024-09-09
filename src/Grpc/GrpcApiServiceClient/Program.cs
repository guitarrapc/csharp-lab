using ConsoleAppFramework;
using Grpc.Net.Client;
using GrpcApiService;

// args = new[] { "Greeter", "--name", "foo" };
// args = new[] { "Duplexer", "--names", "foo bar piyo end" };

var app = ConsoleApp.Create();
app.Add<Client>();
app.Run(args);

public class Client
{
    /// <summary>
    /// Send Unary Request to Server
    /// </summary>
    /// <param name="name">Name in request</param>
    /// <param name="serverAddress">Server address to connect</param>
    /// <returns></returns>
    public async Task Greeter(string name, string serverAddress = "http://localhost:5095")
    {
        var channel = GrpcChannel.ForAddress(serverAddress);
        var client = new Greeter.GreeterClient(channel);
        var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
        Console.WriteLine(reply.Message);
    }

    /// <summary>
    /// Send DuplexStreaming request to Server
    /// </summary>
    /// <param name="ct">Cancellataion Token to trigger cancel on Ctrl+C</param>
    /// <param name="name">Name in request</param>
    /// <param name="serverAddress">Server address to connect</param>
    /// <returns></returns>
    public async Task Duplexer(CancellationToken ct, string[] names, string serverAddress = "http://localhost:5095")
    {
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(ct);
        cts.CancelAfter(TimeSpan.FromSeconds(30)); // timeout on 30s or Ctrl+C

        var readCompleted = false;
        var channel = GrpcChannel.ForAddress(serverAddress);
        var client = new Duplexer.DuplexerClient(channel);

        try
        {
            // Connect
            var echo = client.Echo();

            // Read in background thread.
            var _ = Task.Run(async () =>
            {
                while (await echo.ResponseStream.MoveNext(cts.Token))
                {
                    var current = echo.ResponseStream.Current;
                    Console.WriteLine($"Response from Server: {current.Message}");
                }
                readCompleted = true;
            }, cts.Token);

            // Write Request
            foreach (var name in names)
            {
                Console.WriteLine($"Requesting to Server: {name}");
                await echo.RequestStream.WriteAsync(new BidiHelloRequest
                {
                    Name = name,
                }, cts.Token);
            }

            // Wait complete
            while (!readCompleted)
            {
                if (cts.IsCancellationRequested)
                    break;
                await Task.Delay(1000);
            }
        }
        finally
        {
            // Cancel background thread.
            cts.Cancel();
        }
    }
}
