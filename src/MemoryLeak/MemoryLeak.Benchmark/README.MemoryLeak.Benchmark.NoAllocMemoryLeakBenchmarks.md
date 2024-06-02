```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.38 ns** | **1.705 ns** | **0.093 ns** |  **34.29 ns** |  **34.47 ns** |         **-** |
| AllocateArrayPool | 1      |  97.71 ns | 3.956 ns | 0.217 ns |  97.47 ns |  97.86 ns |         - |
| **RentReturn**        | **10**     | **520.25 ns** | **7.840 ns** | **0.430 ns** | **519.77 ns** | **520.60 ns** |         **-** |
| AllocateArrayPool | 10     | 700.53 ns | 1.156 ns | 0.063 ns | 700.47 ns | 700.60 ns |         - |
