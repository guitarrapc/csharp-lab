```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Number | Mean        | Error      | StdDev    | Median      | Min         | Max         | Allocated |
|-------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|------------:|----------:|
| **CidrBlockV4NewString**      | **1**      |  **65.4474 ns** |  **0.5308 ns** | **0.0291 ns** |  **65.4306 ns** |  **65.4305 ns** |  **65.4810 ns** |         **-** |
| CidrBlockV4NewBytes       | 1      |   0.0014 ns |  0.0435 ns | 0.0024 ns |   0.0000 ns |   0.0000 ns |   0.0041 ns |         - |
| CidrBlockV4TryParseString | 1      |  73.6659 ns |  5.1416 ns | 0.2818 ns |  73.5434 ns |  73.4660 ns |  73.9882 ns |         - |
| CidrBlockV4TryParseBytes  | 1      |   3.0365 ns |  0.0158 ns | 0.0009 ns |   3.0361 ns |   3.0360 ns |   3.0375 ns |         - |
| **CidrBlockV4NewString**      | **10**     | **663.6488 ns** | **43.2436 ns** | **2.3703 ns** | **663.0924 ns** | **661.6062 ns** | **666.2478 ns** |         **-** |
| CidrBlockV4NewBytes       | 10     |   3.3092 ns |  0.2802 ns | 0.0154 ns |   3.3011 ns |   3.2995 ns |   3.3269 ns |         - |
| CidrBlockV4TryParseString | 10     | 701.7214 ns | 10.8704 ns | 0.5958 ns | 701.9833 ns | 701.0395 ns | 702.1414 ns |         - |
| CidrBlockV4TryParseBytes  | 10     |  28.5002 ns |  0.6835 ns | 0.0375 ns |  28.4801 ns |  28.4771 ns |  28.5434 ns |         - |
