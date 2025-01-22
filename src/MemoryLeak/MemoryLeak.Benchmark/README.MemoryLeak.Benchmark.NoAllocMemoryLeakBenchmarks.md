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
| **RentReturn**        | **1**      |  **19.37 ns** |  **1.097 ns** | **0.060 ns** |  **19.32 ns** |  **19.43 ns** |         **-** |
| AllocateArrayPool | 1      | 100.40 ns |  3.244 ns | 0.178 ns | 100.25 ns | 100.60 ns |         - |
| **RentReturn**        | **10**     | **412.92 ns** | **36.555 ns** | **2.004 ns** | **411.55 ns** | **415.22 ns** |         **-** |
| AllocateArrayPool | 10     | 575.22 ns | 18.229 ns | 0.999 ns | 574.30 ns | 576.28 ns |         - |
