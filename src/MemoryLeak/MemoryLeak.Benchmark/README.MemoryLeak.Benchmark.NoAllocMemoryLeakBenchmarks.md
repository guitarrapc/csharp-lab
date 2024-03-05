```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **35.95 ns** |  **2.541 ns** | **0.139 ns** |  **35.80 ns** |  **36.08 ns** |         **-** |
| AllocateArrayPool | 1      |  97.78 ns |  1.891 ns | 0.104 ns |  97.68 ns |  97.89 ns |         - |
| **RentReturn**        | **10**     | **539.17 ns** |  **8.756 ns** | **0.480 ns** | **538.62 ns** | **539.53 ns** |         **-** |
| AllocateArrayPool | 10     | 697.77 ns | 20.119 ns | 1.103 ns | 696.56 ns | 698.71 ns |         - |
