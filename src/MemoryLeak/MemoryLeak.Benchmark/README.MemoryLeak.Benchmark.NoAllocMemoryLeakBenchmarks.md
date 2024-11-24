```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **35.14 ns** |   **0.079 ns** |  **0.004 ns** |  **35.13 ns** |  **35.14 ns** |         **-** |
| AllocateArrayPool | 1      |  97.62 ns |   0.938 ns |  0.051 ns |  97.56 ns |  97.66 ns |         - |
| **RentReturn**        | **10**     | **531.35 ns** | **243.476 ns** | **13.346 ns** | **523.12 ns** | **546.75 ns** |         **-** |
| AllocateArrayPool | 10     | 702.29 ns |  76.465 ns |  4.191 ns | 698.38 ns | 706.72 ns |         - |
