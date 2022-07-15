using Grpc.Net.Client;
using GrpcApiService;

// args = new[] { "Greeter", "--name", "foo" };
// args = new[] { "Duplexer", "--names", "foo bar piyo end" };

var app = ConsoleApp.Create(args);
app.AddCommands<Client>();
app.Run();

public class Client : ConsoleAppBase
{
    public async Task Greeter(string name, string serverAddress = "http://localhost:5095")
    {
        var channel = GrpcChannel.ForAddress(serverAddress);
        var client = new Greeter.GreeterClient(channel);
        var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
        Console.WriteLine(reply.Message);
    }

    public async Task Duplexer(string[] names, string serverAddress = "http://localhost:5095")
    {
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(Context.CancellationToken);
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
                    Console.WriteLine(current.Message);
                }
                readCompleted = true;
            }, cts.Token);

            // Write Request
            foreach (var name in names)
            {
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
