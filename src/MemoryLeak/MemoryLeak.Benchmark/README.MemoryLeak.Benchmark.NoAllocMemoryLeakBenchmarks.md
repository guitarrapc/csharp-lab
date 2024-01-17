```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.58 ns** |   **0.809 ns** |  **0.044 ns** |  **34.53 ns** |  **34.62 ns** |         **-** |
| AllocateArrayPool | 1      |  97.14 ns |   2.089 ns |  0.114 ns |  97.01 ns |  97.21 ns |         - |
| **RentReturn**        | **10**     | **532.85 ns** | **186.578 ns** | **10.227 ns** | **526.17 ns** | **544.63 ns** |         **-** |
| AllocateArrayPool | 10     | 702.27 ns |  89.542 ns |  4.908 ns | 699.12 ns | 707.93 ns |         - |
