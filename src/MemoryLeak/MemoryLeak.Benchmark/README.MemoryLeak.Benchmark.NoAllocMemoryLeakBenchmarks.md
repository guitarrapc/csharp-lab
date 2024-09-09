```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **32.77 ns** |  **0.677 ns** | **0.037 ns** |  **32.74 ns** |  **32.81 ns** |         **-** |
| AllocateArrayPool | 1      |  97.51 ns |  1.464 ns | 0.080 ns |  97.46 ns |  97.60 ns |         - |
| **RentReturn**        | **10**     | **528.51 ns** | **43.107 ns** | **2.363 ns** | **525.90 ns** | **530.51 ns** |         **-** |
| AllocateArrayPool | 10     | 697.78 ns | 44.810 ns | 2.456 ns | 695.06 ns | 699.82 ns |         - |
