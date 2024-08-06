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
| **RentReturn**        | **1**      |  **36.84 ns** |  **0.733 ns** | **0.040 ns** |  **36.81 ns** |  **36.89 ns** |         **-** |
| AllocateArrayPool | 1      |  97.70 ns |  1.206 ns | 0.066 ns |  97.66 ns |  97.78 ns |         - |
| **RentReturn**        | **10**     | **561.70 ns** | **23.754 ns** | **1.302 ns** | **560.20 ns** | **562.46 ns** |         **-** |
| AllocateArrayPool | 10     | 697.54 ns | 21.347 ns | 1.170 ns | 696.46 ns | 698.78 ns |         - |
