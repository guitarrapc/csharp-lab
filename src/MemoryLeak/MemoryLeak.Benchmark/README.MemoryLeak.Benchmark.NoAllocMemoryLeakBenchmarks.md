```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.15 ns** |  **1.525 ns** | **0.084 ns** |  **36.07 ns** |  **36.24 ns** |         **-** |
| AllocateArrayPool | 1      | 102.17 ns |  3.320 ns | 0.182 ns | 102.05 ns | 102.38 ns |         - |
| **RentReturn**        | **10**     | **521.14 ns** |  **9.667 ns** | **0.530 ns** | **520.53 ns** | **521.47 ns** |         **-** |
| AllocateArrayPool | 10     | 716.57 ns | 28.814 ns | 1.579 ns | 715.42 ns | 718.37 ns |         - |
