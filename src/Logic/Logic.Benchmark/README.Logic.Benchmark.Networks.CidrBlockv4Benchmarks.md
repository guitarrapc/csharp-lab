```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.0442 ns** | **0.2900 ns** | **0.0159 ns** |  **65.0411 ns** |  **65.0301 ns** |  **65.0614 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0531 ns | 1.0291 ns | 0.0564 ns |   0.0213 ns |   0.0197 ns |   0.1182 ns |         - |
| TryParseCidrString | 1      |  72.5313 ns | 4.4461 ns | 0.2437 ns |  72.4792 ns |  72.3179 ns |  72.7969 ns |         - |
| TryParseCidrBytes  | 1      |   2.7502 ns | 0.0800 ns | 0.0044 ns |   2.7517 ns |   2.7452 ns |   2.7536 ns |         - |
| **NewFromCidrString**  | **3**      | **194.5471 ns** | **3.5860 ns** | **0.1966 ns** | **194.4376 ns** | **194.4296 ns** | **194.7740 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6375 ns | 0.0070 ns | 0.0004 ns |   0.6376 ns |   0.6371 ns |   0.6379 ns |         - |
| TryParseCidrString | 3      | 209.4659 ns | 2.8846 ns | 0.1581 ns | 209.4894 ns | 209.2974 ns | 209.6110 ns |         - |
| TryParseCidrBytes  | 3      |   9.2826 ns | 1.1536 ns | 0.0632 ns |   9.2502 ns |   9.2422 ns |   9.3555 ns |         - |
