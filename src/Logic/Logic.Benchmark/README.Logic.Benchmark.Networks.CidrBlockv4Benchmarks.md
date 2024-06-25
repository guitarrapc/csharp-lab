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
| **NewFromCidrString**  | **1**      |  **65.3655 ns** |  **3.0052 ns** | **0.1647 ns** |  **65.2270 ns** |  **65.5476 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.2638 ns | 17.1685 ns | 0.9411 ns |  73.6777 ns |  75.3493 ns |         - |
| TryParseCidrBytes  | 1      |   3.0399 ns |  0.2051 ns | 0.0112 ns |   3.0331 ns |   3.0529 ns |         - |
| **NewFromCidrString**  | **3**      | **200.7651 ns** | **73.7318 ns** | **4.0415 ns** | **198.4107 ns** | **205.4317 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6001 ns |  0.0540 ns | 0.0030 ns |   0.5977 ns |   0.6034 ns |         - |
| TryParseCidrString | 3      | 228.3447 ns |  6.8325 ns | 0.3745 ns | 227.9167 ns | 228.6124 ns |         - |
| TryParseCidrBytes  | 3      |   9.1614 ns |  1.3402 ns | 0.0735 ns |   9.0862 ns |   9.2330 ns |         - |
