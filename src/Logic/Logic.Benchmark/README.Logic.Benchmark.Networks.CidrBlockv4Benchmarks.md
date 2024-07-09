```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.1763 ns** |  **1.2187 ns** | **0.0668 ns** |  **67.1648 ns** |  **67.1159 ns** |  **67.2481 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0478 ns |  1.4035 ns | 0.0769 ns |   0.0068 ns |   0.0000 ns |   0.1365 ns |         - |
| TryParseCidrString | 1      |  73.8352 ns |  3.2996 ns | 0.1809 ns |  73.7341 ns |  73.7274 ns |  74.0440 ns |         - |
| TryParseCidrBytes  | 1      |   3.0433 ns |  0.2272 ns | 0.0125 ns |   3.0367 ns |   3.0356 ns |   3.0577 ns |         - |
| **NewFromCidrString**  | **3**      | **202.9459 ns** |  **3.5313 ns** | **0.1936 ns** | **202.9548 ns** | **202.7481 ns** | **203.1349 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.5981 ns |  0.0072 ns | 0.0004 ns |   0.5979 ns |   0.5978 ns |   0.5985 ns |         - |
| TryParseCidrString | 3      | 214.1142 ns | 12.0625 ns | 0.6612 ns | 213.7826 ns | 213.6845 ns | 214.8756 ns |         - |
| TryParseCidrBytes  | 3      |   9.1810 ns |  3.5754 ns | 0.1960 ns |   9.2517 ns |   8.9595 ns |   9.3319 ns |         - |
