using Logic;

Console.WriteLine($"SandboxConsoleApp running.");

var sw = ValueStopwatch.StartNew();

Console.WriteLine("  - ExponentialBackoff sample.");
// Exponential Backoff. begin delay fro 1000ms, exponential max to 5000ms, max retry 10, timeout is 20s
await Logic.SandboxExponentialBackoff.RunAsync(100, 1000, 10, TimeSpan.FromSeconds(20));
// Result - 100 to 1000
// [19/05/2023 00:25:29] retries: 1, diff: 110 <- begin with 1000.
// [19/05/2023 00:25:31] retries: 2, diff: 210
// [19/05/2023 00:25:35] retries: 3, diff: 406 <- max reached!!!
// [19/05/2023 00:25:39] retries: 4, diff: 824 <- keep max.
// [19/05/2023 00:25:43] retries: 5, diff: 1013
// [19/05/2023 00:25:47] retries: 6, diff: 1006
// [19/05/2023 00:25:47] retries: 7, diff: 1003
// [19/05/2023 00:25:47] retries: 8, diff: 1007
// [19/05/2023 00:25:47] retries: 9, diff: 1012
// [19/05/2023 00:25:47] retries: 10, diff: 1011
// completed.

// Result - 1000 to 5000
// [19/05/2023 00:25:29] retries: 1, diff: 1013 <- begin with 1000.
// [19/05/2023 00:25:31] retries: 2, diff: 2002
// [19/05/2023 00:25:35] retries: 3, diff: 4001 <- max reached!!!
// [19/05/2023 00:25:39] retries: 4, diff: 4009 <- keep max.
// [19/05/2023 00:25:43] retries: 5, diff: 4015
// [19/05/2023 00:25:47] retries: 6, diff: 4005
// timeout reached.                             <- 20s is too short before retying 10 times.

Console.WriteLine($"  - ValueStopwatch Elapsted {sw.GetElapsedTime()}");

Console.WriteLine($"  - String Reverse.");
var input = StringReverse.GenerateText();
var reverse = new StringReverse();
Console.WriteLine($"    * {input} -> {reverse.ArrayReverse(input)}");
