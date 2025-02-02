```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **50.4353 ns** | **1.8045 ns** | **0.0989 ns** |  **50.3212 ns** |  **50.4962 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6246 ns | 0.0643 ns | 0.0035 ns |   0.6218 ns |   0.6285 ns |         - |
| TryParseCidrString | 1      |  52.5901 ns | 0.7848 ns | 0.0430 ns |  52.5437 ns |  52.6286 ns |         - |
| TryParseCidrBytes  | 1      |   3.0906 ns | 0.0401 ns | 0.0022 ns |   3.0884 ns |   3.0927 ns |         - |
| **NewFromCidrString**  | **3**      | **148.3013 ns** | **5.0152 ns** | **0.2749 ns** | **148.1380 ns** | **148.6187 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6268 ns | 0.1692 ns | 0.0093 ns |   0.6210 ns |   0.6375 ns |         - |
| TryParseCidrString | 3      | 155.9521 ns | 1.7287 ns | 0.0948 ns | 155.8527 ns | 156.0415 ns |         - |
| TryParseCidrBytes  | 3      |   9.2882 ns | 1.1008 ns | 0.0603 ns |   9.2187 ns |   9.3269 ns |         - |
