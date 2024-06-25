```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.16 ns** |  **1.970 ns** | **0.108 ns** |  **34.05 ns** |  **34.26 ns** |         **-** |
| AllocateArrayPool | 1      | 100.37 ns | 13.297 ns | 0.729 ns |  99.89 ns | 101.21 ns |         - |
| **RentReturn**        | **10**     | **533.71 ns** | **34.742 ns** | **1.904 ns** | **532.36 ns** | **535.89 ns** |         **-** |
| AllocateArrayPool | 10     | 707.84 ns |  5.834 ns | 0.320 ns | 707.57 ns | 708.20 ns |         - |
