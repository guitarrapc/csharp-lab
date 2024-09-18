```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **37.71 ns** |   **0.549 ns** |  **0.030 ns** |  **37.68 ns** |  **37.74 ns** |         **-** |
| AllocateArrayPool | 1      |  97.88 ns |   3.550 ns |  0.195 ns |  97.66 ns |  98.02 ns |         - |
| **RentReturn**        | **10**     | **521.67 ns** |  **25.545 ns** |  **1.400 ns** | **520.24 ns** | **523.04 ns** |         **-** |
| AllocateArrayPool | 10     | 710.24 ns | 214.923 ns | 11.781 ns | 702.11 ns | 723.75 ns |         - |
