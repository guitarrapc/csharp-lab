```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.2520 ns** | **0.5547 ns** | **0.0304 ns** |  **65.2280 ns** |  **65.2862 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.2516 ns | 1.2345 ns | 0.0677 ns |  73.1868 ns |  73.3218 ns |         - |
| TryParseCidrBytes  | 1      |   3.0312 ns | 0.0061 ns | 0.0003 ns |   3.0309 ns |   3.0315 ns |         - |
| **NewFromCidrString**  | **3**      | **196.0162 ns** | **5.6306 ns** | **0.3086 ns** | **195.7553 ns** | **196.3569 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6060 ns | 0.1275 ns | 0.0070 ns |   0.5980 ns |   0.6106 ns |         - |
| TryParseCidrString | 3      | 212.3843 ns | 5.3056 ns | 0.2908 ns | 212.1044 ns | 212.6849 ns |         - |
| TryParseCidrBytes  | 3      |   9.1794 ns | 2.3912 ns | 0.1311 ns |   9.1035 ns |   9.3308 ns |         - |
