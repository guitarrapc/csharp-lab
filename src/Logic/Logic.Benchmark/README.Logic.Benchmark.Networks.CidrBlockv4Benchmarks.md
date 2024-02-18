```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev     | Min         | Max         | Allocated |
|------------------- |------- |------------:|------------:|-----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.9891 ns** |  **30.3339 ns** |  **1.6627 ns** |  **64.9668 ns** |  **67.9076 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |   0.0000 ns |  0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.3853 ns |   2.9859 ns |  0.1637 ns |  73.2697 ns |  73.5726 ns |         - |
| TryParseCidrBytes  | 1      |   3.0422 ns |   0.2734 ns |  0.0150 ns |   3.0333 ns |   3.0595 ns |         - |
| **NewFromCidrString**  | **10**     | **690.9992 ns** | **761.7933 ns** | **41.7565 ns** | **666.8288 ns** | **739.2154 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3028 ns |   0.1857 ns |  0.0102 ns |   3.2944 ns |   3.3141 ns |         - |
| TryParseCidrString | 10     | 709.6073 ns |  22.6978 ns |  1.2441 ns | 708.5736 ns | 710.9882 ns |         - |
| TryParseCidrBytes  | 10     |  28.4945 ns |   0.1943 ns |  0.0107 ns |  28.4877 ns |  28.5068 ns |         - |
