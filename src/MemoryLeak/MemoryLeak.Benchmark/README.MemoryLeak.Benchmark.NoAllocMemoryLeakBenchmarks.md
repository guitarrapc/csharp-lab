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
| **RentReturn**        | **1**      |  **34.15 ns** |  **1.404 ns** | **0.077 ns** |  **34.09 ns** |  **34.24 ns** |         **-** |
| AllocateArrayPool | 1      |  97.51 ns |  2.208 ns | 0.121 ns |  97.40 ns |  97.64 ns |         - |
| **RentReturn**        | **10**     | **526.82 ns** | **18.687 ns** | **1.024 ns** | **525.64 ns** | **527.43 ns** |         **-** |
| AllocateArrayPool | 10     | 702.26 ns | 20.308 ns | 1.113 ns | 700.98 ns | 703.00 ns |         - |
