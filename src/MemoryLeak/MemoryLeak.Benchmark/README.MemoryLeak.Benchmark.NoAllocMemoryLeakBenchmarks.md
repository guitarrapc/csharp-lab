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
| **RentReturn**        | **1**      |  **37.93 ns** |  **0.185 ns** | **0.010 ns** |  **37.92 ns** |  **37.94 ns** |         **-** |
| AllocateArrayPool | 1      |  97.74 ns |  2.379 ns | 0.130 ns |  97.60 ns |  97.86 ns |         - |
| **RentReturn**        | **10**     | **521.07 ns** | **35.705 ns** | **1.957 ns** | **519.01 ns** | **522.90 ns** |         **-** |
| AllocateArrayPool | 10     | 702.41 ns | 12.353 ns | 0.677 ns | 701.88 ns | 703.17 ns |         - |
