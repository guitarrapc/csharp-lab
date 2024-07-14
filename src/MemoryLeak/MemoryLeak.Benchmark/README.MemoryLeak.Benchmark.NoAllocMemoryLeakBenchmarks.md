```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.13 ns** |  **1.099 ns** | **0.060 ns** |  **36.07 ns** |  **36.19 ns** |         **-** |
| AllocateArrayPool | 1      | 100.94 ns |  5.762 ns | 0.316 ns | 100.71 ns | 101.30 ns |         - |
| **RentReturn**        | **10**     | **523.01 ns** | **22.521 ns** | **1.234 ns** | **521.72 ns** | **524.18 ns** |         **-** |
| AllocateArrayPool | 10     | 740.61 ns | 20.788 ns | 1.139 ns | 739.31 ns | 741.39 ns |         - |
