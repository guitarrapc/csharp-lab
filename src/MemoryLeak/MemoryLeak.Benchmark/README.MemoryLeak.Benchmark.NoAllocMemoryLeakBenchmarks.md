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
| **RentReturn**        | **1**      |  **35.77 ns** |  **0.518 ns** | **0.028 ns** |  **35.74 ns** |  **35.79 ns** |         **-** |
| AllocateArrayPool | 1      |  99.88 ns |  3.860 ns | 0.212 ns |  99.70 ns | 100.11 ns |         - |
| **RentReturn**        | **10**     | **525.66 ns** |  **7.097 ns** | **0.389 ns** | **525.27 ns** | **526.05 ns** |         **-** |
| AllocateArrayPool | 10     | 702.14 ns | 64.698 ns | 3.546 ns | 699.71 ns | 706.21 ns |         - |
