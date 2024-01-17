```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Number | Mean        | Error       | StdDev    | Min         | Max         | Allocated |
|-------------------------- |------- |------------:|------------:|----------:|------------:|------------:|----------:|
| **CidrBlockV4NewString**      | **1**      |  **64.9812 ns** |   **6.5504 ns** | **0.3590 ns** |  **64.7705 ns** |  **65.3958 ns** |         **-** |
| CidrBlockV4NewBytes       | 1      |   0.0000 ns |   0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockV4TryParseString | 1      |  74.7911 ns |  30.2583 ns | 1.6586 ns |  73.7578 ns |  76.7042 ns |         - |
| CidrBlockV4TryParseBytes  | 1      |   3.0397 ns |   0.1413 ns | 0.0077 ns |   3.0319 ns |   3.0474 ns |         - |
| **CidrBlockV4NewString**      | **10**     | **661.3066 ns** |  **34.7383 ns** | **1.9041 ns** | **659.8302 ns** | **663.4558 ns** |         **-** |
| CidrBlockV4NewBytes       | 10     |   3.3107 ns |   0.1808 ns | 0.0099 ns |   3.3023 ns |   3.3216 ns |         - |
| CidrBlockV4TryParseString | 10     | 732.6667 ns | 133.4507 ns | 7.3149 ns | 728.3511 ns | 741.1125 ns |         - |
| CidrBlockV4TryParseBytes  | 10     |  28.5062 ns |   0.0978 ns | 0.0054 ns |  28.5000 ns |  28.5095 ns |         - |
