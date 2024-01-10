```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | Number | Mean        | Error       | StdDev     | Min         | Max         | Allocated |
|------------------------ |------- |------------:|------------:|-----------:|------------:|------------:|----------:|
| **CidrBlockNewString**      | **1**      |  **59.6862 ns** |   **1.2771 ns** |  **0.0700 ns** |  **59.6258 ns** |  **59.7629 ns** |         **-** |
| CidrBlockNewBytes       | 1      |   0.0000 ns |   0.0000 ns |  0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockTryParseString | 1      |  62.4558 ns |   1.7372 ns |  0.0952 ns |  62.3508 ns |  62.5365 ns |         - |
| CidrBlockTryParseBytes  | 1      |   3.0357 ns |   0.0668 ns |  0.0037 ns |   3.0318 ns |   3.0390 ns |         - |
| **CidrBlockNewString**      | **10**     | **612.6351 ns** | **185.5870 ns** | **10.1727 ns** | **606.0290 ns** | **624.3496 ns** |         **-** |
| CidrBlockNewBytes       | 10     |   3.3011 ns |   0.0408 ns |  0.0022 ns |   3.2989 ns |   3.3034 ns |         - |
| CidrBlockTryParseString | 10     | 660.6481 ns |   7.8112 ns |  0.4282 ns | 660.1540 ns | 660.9103 ns |         - |
| CidrBlockTryParseBytes  | 10     |  28.7064 ns |   1.7433 ns |  0.0956 ns |  28.6034 ns |  28.7922 ns |         - |
