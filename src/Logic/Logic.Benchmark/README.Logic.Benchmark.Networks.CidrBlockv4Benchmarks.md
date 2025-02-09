```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **50.5327 ns** |  **5.5400 ns** | **0.3037 ns** |  **50.3498 ns** |  **50.8832 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6240 ns |  0.0530 ns | 0.0029 ns |   0.6212 ns |   0.6270 ns |         - |
| TryParseCidrString | 1      |  52.5798 ns |  0.8421 ns | 0.0462 ns |  52.5501 ns |  52.6329 ns |         - |
| TryParseCidrBytes  | 1      |   3.0933 ns |  0.0942 ns | 0.0052 ns |   3.0893 ns |   3.0991 ns |         - |
| **NewFromCidrString**  | **3**      | **148.0461 ns** | **13.0872 ns** | **0.7174 ns** | **147.3890 ns** | **148.8114 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6292 ns |  0.0537 ns | 0.0029 ns |   0.6258 ns |   0.6311 ns |         - |
| TryParseCidrString | 3      | 155.0480 ns |  1.5126 ns | 0.0829 ns | 154.9698 ns | 155.1349 ns |         - |
| TryParseCidrBytes  | 3      |   9.3741 ns |  0.3895 ns | 0.0213 ns |   9.3511 ns |   9.3933 ns |         - |
