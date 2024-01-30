```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.11 ns** |  **1.463 ns** | **0.080 ns** |  **34.05 ns** |  **34.20 ns** |         **-** |
| AllocateArrayPool | 1      |  97.20 ns |  2.858 ns | 0.157 ns |  97.06 ns |  97.37 ns |         - |
| **RentReturn**        | **10**     | **528.55 ns** |  **1.564 ns** | **0.086 ns** | **528.46 ns** | **528.63 ns** |         **-** |
| AllocateArrayPool | 10     | 702.45 ns | 24.667 ns | 1.352 ns | 700.90 ns | 703.40 ns |         - |
