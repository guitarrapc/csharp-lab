```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **35.05 ns** |   **1.066 ns** | **0.058 ns** |  **34.99 ns** |  **35.11 ns** |         **-** |
| AllocateArrayPool | 1      |  98.06 ns |   5.388 ns | 0.295 ns |  97.72 ns |  98.24 ns |         - |
| **RentReturn**        | **10**     | **526.45 ns** |  **15.365 ns** | **0.842 ns** | **525.50 ns** | **527.11 ns** |         **-** |
| AllocateArrayPool | 10     | 709.66 ns | 124.879 ns | 6.845 ns | 701.81 ns | 714.43 ns |         - |
