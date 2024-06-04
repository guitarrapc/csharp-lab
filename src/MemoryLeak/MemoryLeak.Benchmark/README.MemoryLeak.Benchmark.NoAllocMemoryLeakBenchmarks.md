```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.15 ns** |  **0.376 ns** | **0.021 ns** |  **34.14 ns** |  **34.18 ns** |         **-** |
| AllocateArrayPool | 1      | 102.05 ns |  1.431 ns | 0.078 ns | 101.97 ns | 102.13 ns |         - |
| **RentReturn**        | **10**     | **526.38 ns** | **40.801 ns** | **2.236 ns** | **523.84 ns** | **528.06 ns** |         **-** |
| AllocateArrayPool | 10     | 807.67 ns | 15.214 ns | 0.834 ns | 807.11 ns | 808.63 ns |         - |
