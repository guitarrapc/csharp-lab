```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.18 ns** |   **0.680 ns** |  **0.037 ns** |  **34.14 ns** |  **34.22 ns** |         **-** |
| AllocateArrayPool | 1      |  97.59 ns |   6.925 ns |  0.380 ns |  97.17 ns |  97.89 ns |         - |
| **RentReturn**        | **10**     | **530.42 ns** |  **34.312 ns** |  **1.881 ns** | **528.25 ns** | **531.56 ns** |         **-** |
| AllocateArrayPool | 10     | 734.66 ns | 460.531 ns | 25.243 ns | 713.78 ns | 762.71 ns |         - |
