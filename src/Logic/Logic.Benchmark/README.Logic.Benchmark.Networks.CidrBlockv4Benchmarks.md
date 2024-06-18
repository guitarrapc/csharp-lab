```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.3819 ns** |  **0.1962 ns** | **0.0108 ns** |  **65.3698 ns** |  **65.3905 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8482 ns |  3.6049 ns | 0.1976 ns |  73.6913 ns |  74.0701 ns |         - |
| TryParseCidrBytes  | 1      |   3.0440 ns |  0.2550 ns | 0.0140 ns |   3.0357 ns |   3.0601 ns |         - |
| **NewFromCidrString**  | **3**      | **199.2888 ns** | **13.7173 ns** | **0.7519 ns** | **198.6645 ns** | **200.1235 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.5984 ns |  0.0143 ns | 0.0008 ns |   0.5978 ns |   0.5993 ns |         - |
| TryParseCidrString | 3      | 212.3599 ns |  3.7716 ns | 0.2067 ns | 212.2194 ns | 212.5973 ns |         - |
| TryParseCidrBytes  | 3      |   9.2716 ns |  1.7356 ns | 0.0951 ns |   9.1754 ns |   9.3657 ns |         - |
