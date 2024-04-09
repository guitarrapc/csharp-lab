```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.5682 ns** |  **3.6514 ns** | **0.2001 ns** |  **64.4140 ns** |  **64.7944 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  72.2624 ns |  5.7582 ns | 0.3156 ns |  71.8983 ns |  72.4597 ns |         - |
| TryParseCidrBytes  | 1      |   2.9571 ns |  1.3069 ns | 0.0716 ns |   2.8748 ns |   3.0058 ns |         - |
| **NewFromCidrString**  | **3**      | **197.1664 ns** | **15.4813 ns** | **0.8486 ns** | **196.2039 ns** | **197.8066 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6039 ns |  0.0800 ns | 0.0044 ns |   0.6006 ns |   0.6089 ns |         - |
| TryParseCidrString | 3      | 212.4572 ns |  5.0511 ns | 0.2769 ns | 212.1898 ns | 212.7427 ns |         - |
| TryParseCidrBytes  | 3      |   9.2630 ns |  1.4000 ns | 0.0767 ns |   9.1750 ns |   9.3164 ns |         - |
