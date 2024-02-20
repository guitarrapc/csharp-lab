```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.76 ns** |  **0.452 ns** | **0.025 ns** |  **36.73 ns** |  **36.78 ns** |         **-** |
| AllocateArrayPool | 1      |  97.22 ns |  2.482 ns | 0.136 ns |  97.09 ns |  97.37 ns |         - |
| **RentReturn**        | **10**     | **523.53 ns** | **87.679 ns** | **4.806 ns** | **520.72 ns** | **529.08 ns** |         **-** |
| AllocateArrayPool | 10     | 697.82 ns | 14.470 ns | 0.793 ns | 696.93 ns | 698.45 ns |         - |
