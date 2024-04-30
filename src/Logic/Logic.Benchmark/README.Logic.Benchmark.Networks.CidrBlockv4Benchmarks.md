```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **66.7929 ns** |  **1.7713 ns** | **0.0971 ns** |  **66.7322 ns** |  **66.9049 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.2490 ns | 10.9466 ns | 0.6000 ns |  73.8001 ns |  74.9305 ns |         - |
| TryParseCidrBytes  | 1      |   3.0356 ns |  0.0091 ns | 0.0005 ns |   3.0350 ns |   3.0358 ns |         - |
| **NewFromCidrString**  | **3**      | **196.4787 ns** | **32.6165 ns** | **1.7878 ns** | **195.1437 ns** | **198.5099 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6036 ns |  0.1167 ns | 0.0064 ns |   0.5993 ns |   0.6110 ns |         - |
| TryParseCidrString | 3      | 212.7978 ns |  2.7535 ns | 0.1509 ns | 212.6455 ns | 212.9473 ns |         - |
| TryParseCidrBytes  | 3      |   9.2905 ns |  1.6011 ns | 0.0878 ns |   9.2184 ns |   9.3882 ns |         - |
