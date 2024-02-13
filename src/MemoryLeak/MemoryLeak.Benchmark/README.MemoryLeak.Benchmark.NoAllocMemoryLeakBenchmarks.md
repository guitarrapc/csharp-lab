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
| **RentReturn**        | **1**      |  **34.42 ns** |   **1.384 ns** |  **0.076 ns** |  **34.36 ns** |  **34.50 ns** |         **-** |
| AllocateArrayPool | 1      |  97.74 ns |   3.432 ns |  0.188 ns |  97.59 ns |  97.95 ns |         - |
| **RentReturn**        | **10**     | **533.84 ns** |  **12.263 ns** |  **0.672 ns** | **533.31 ns** | **534.60 ns** |         **-** |
| AllocateArrayPool | 10     | 709.50 ns | 201.077 ns | 11.022 ns | 702.44 ns | 722.20 ns |         - |
