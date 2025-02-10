```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **19.29 ns** |  **0.341 ns** | **0.019 ns** |  **19.27 ns** |  **19.31 ns** |         **-** |
| AllocateArrayPool | 1      |  81.96 ns |  0.778 ns | 0.043 ns |  81.92 ns |  82.00 ns |         - |
| **RentReturn**        | **10**     | **417.63 ns** | **13.873 ns** | **0.760 ns** | **417.14 ns** | **418.50 ns** |         **-** |
| AllocateArrayPool | 10     | 663.48 ns | 75.023 ns | 4.112 ns | 660.91 ns | 668.22 ns |         - |
