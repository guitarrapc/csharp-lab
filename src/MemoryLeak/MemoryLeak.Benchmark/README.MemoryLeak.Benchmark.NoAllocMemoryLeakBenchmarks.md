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
| **RentReturn**        | **1**      |  **19.28 ns** |  **0.302 ns** | **0.017 ns** |  **19.26 ns** |  **19.29 ns** |         **-** |
| AllocateArrayPool | 1      |  81.71 ns |  7.433 ns | 0.407 ns |  81.26 ns |  82.04 ns |         - |
| **RentReturn**        | **10**     | **412.97 ns** | **18.421 ns** | **1.010 ns** | **412.23 ns** | **414.12 ns** |         **-** |
| AllocateArrayPool | 10     | 575.57 ns | 64.529 ns | 3.537 ns | 572.96 ns | 579.60 ns |         - |
