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
| **CidrBlockV4NewString**      | **1**      |  **64.7602 ns** |  **1.9817 ns** | **0.1086 ns** |  **64.8041 ns** |  **64.6364 ns** |  **64.8399 ns** |         **-** |
| CidrBlockV4NewBytes       | 1      |   0.0001 ns |  0.0039 ns | 0.0002 ns |   0.0000 ns |   0.0000 ns |   0.0004 ns |         - |
| CidrBlockV4TryParseString | 1      |  74.5012 ns |  0.5868 ns | 0.0322 ns |  74.4915 ns |  74.4750 ns |  74.5371 ns |         - |
| CidrBlockV4TryParseBytes  | 1      |   3.0437 ns |  0.2142 ns | 0.0117 ns |   3.0413 ns |   3.0334 ns |   3.0565 ns |         - |
| **CidrBlockV4NewString**      | **10**     | **661.4100 ns** | **10.5525 ns** | **0.5784 ns** | **661.1990 ns** | **660.9667 ns** | **662.0643 ns** |         **-** |
| CidrBlockV4NewBytes       | 10     |   3.3143 ns |  0.3103 ns | 0.0170 ns |   3.3155 ns |   3.2967 ns |   3.3306 ns |         - |
| CidrBlockV4TryParseString | 10     | 704.4112 ns |  9.1519 ns | 0.5016 ns | 704.6715 ns | 703.8329 ns | 704.7292 ns |         - |
| CidrBlockV4TryParseBytes  | 10     |  28.6817 ns |  0.7736 ns | 0.0424 ns |  28.7009 ns |  28.6331 ns |  28.7111 ns |         - |
